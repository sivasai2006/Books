#https://github.com/sparkbyexamples/spark-examples/tree/master/spark-streaming/src/main/resources/folder_streaming

from pyspark import SparkContext
from pyspark.streaming import StreamingContext
from pyspark.sql import Row, SparkSession
from pyspark.sql.types import *

spark = SparkSession.builder.master("local[*]")\
    .appName("JSONStreaming")\
    .getOrCreate()

spark.sparkContext.setLogLevel("ERROR")

schema = StructType([
    StructField("RecordNumber", IntegerType(), True),
    StructField("Zipcode", StringType(), True),
    StructField("ZipCodeType", StringType(), True),
    StructField("City", StringType(), True),
    StructField("State", StringType(), True),
    StructField("LocationType", StringType(), True),
    StructField("Lat", StringType(), True),
    StructField("Long", StringType(), True),
    StructField("Xaxis", StringType(), True),
    StructField("Yaxis", StringType(), True),
    StructField("Zaxis", StringType(), True),
    StructField("WorldRegion", StringType(), True),
    StructField("Country", StringType(), True),
    StructField("LocationText", StringType(), True),
    StructField("Location", StringType(), True),
    StructField("Decommisioned", StringType(), True)
  ])

df = spark.readStream.schema(schema).json("/home/hdadmin/JSONStreamData")

df.printSchema()

df.show()

groupDF = df.select("Zipcode").groupBy("Zipcode").count()
groupDF.printSchema()

groupDF.writeStream\
    .format("console")\
    .outputMode("complete")\
    .option("truncate",False)\
    .option("newRows",30)\
    .start()\
    .awaitTermination()
