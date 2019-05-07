%python
#query.stop()
#spark.stop()
from pyspark.sql.types import *
from pyspark.sql import SQLContext 
from pyspark.sql import SparkSession
import time
spark = SparkSession \
    .builder \
    .appName("Read Streaming Json") \
    .getOrCreate()

spark.conf.set("spark.sql.streaming.schemaInference", True)


inputPath = "/FileStore/tables"

# Since we know the data format already, let's define the schema to speed up processing (no need for Spark to infer schema)
jsonSchema = StructType([ StructField("db_connection", StringType(), True),  StructField("db_user", StringType(), True),StructField("db_pass", StringType(), True) ])
staticInputDF = spark.readStream.option("maxFilesPerTrigger", 1).json(inputPath,multiLine=True) 
#staticInputDF.isStreaming()
#staticInputDF.printSchema()
query=staticInputDF.writeStream.format("console").outputMode("append").queryName("counts").start()
query.awaitTermination()
