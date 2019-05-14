from pyspark import SparkContext
from pyspark.streaming import StreamingContext
from pyspark.sql import Row, SparkSession
from pyspark.sql.utils import AnalysisException

if __name__ == "__main__":

    spark = SparkSession\
        .builder\
        .appName("PythonSqlStreaming") \
        .config("spark.debug.maxToStringFields", 100) \
        .enableHiveSupport() \
        .getOrCreate()

    hive_business_table = spark.sql("SELECT * FROM discovery_tph.tph_rdm_events")
    hive_business_table.persist(spark.StorageLevel.MEMORY)

    sc = spark.sparkContext
    ssc = StreamingContext(sc, 10)

    json_text = ssc.textFileStream("C:\\CodePlay\\dat\\input\\*.dat")
    json_rdd = json_text.map(lambda x: x[2:-1] if x else x).flatMap(lambda y: y.split("],["))

    def has_column(df, col):
        try:
            df[col]
            return True
        except AnalysisException:
            return False

    def process(time, rdd):
        print("========= %s =========" % str(time))

        try:
            df = spark.read.json(rdd)

            if has_column(df, "sourceSystemCode"):
                filtered_df=df.filter(df.sourceSystemCode.startswith("BC"))
                #filtered_df.show()

                # Creates a temporary view using the DataFrame.
                filtered_df.createOrReplaceTempView("records")
                records_table = spark.sql("SELECT * FROM records")
                records_table.show()

                valid_records = records_table.join(hive_business_table,
                                                   records_table.touchpointTransactionContextCode == hive_business_table.domaincodevalue)
                valid_records.show()

            else:
                print("No data available")

        except:
            pass

    json_rdd.foreachRDD(process)

    ssc.start()
    ssc.awaitTermination()
