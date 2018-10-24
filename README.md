# Sqoop
http://sqoop.apache.org/docs/1.4.2/SqoopUserGuide.html


# Hive
https://qubole.zendesk.com/hc/en-us/articles/214885263-HIVE-Dynamic-Partitioning-tips

1. Convert External table to Internal table or vice-versa
   External Tables and Internal Tables (non-External) differ only in the aspect that dropping the table drops meta-data in External          tables, whereas it drops both meta-data and data in the case of Internal tables.
   
   Use the following command to convert an external table to an internal table:

    ```ALTER TABLE <tablename> SET TBLPROPERTIES('EXTERNAL'='FALSE');```

   Use the following command to convert an internal table to an external table:

    ```ALTER TABLE <tablename> SET TBLPROPERTIES('EXTERNAL'='TRUE');```


# Shell Script

https://chmodcommand.com/
File protection with chmod

|Command	      | Meaning                                                                                                          |
|:--------------|:-----------------------------------------------------------------------------------------------------------------| 
|chmod 400     | file	To protect a file against accidental overwriting.                                                         |
|chmod 500     | directory	To protect yourself from accidentally removing, renaming or moving files from this directory.          |
|chmod 600     | file	A private file only changeable by the user who entered this command.                                      |
|chmod 644     | file	A publicly readable file that can only be changed by the issuing user.                                    |
|chmod 660     | file	Users belonging to your group can change this file, others don't have any access to it at all.            |
|chmod 700     | file	Protects a file against any access from other users, while the issuing user still has full access.        |
|chmod 755     | directory	For files that should be readable and executable by others, but only changeable by the issuing user.   |
|chmod 775     | file	Standard file sharing mode for a group.                                                                   |
|chmod 777     | file	Everybody can do everything to this file.                                                                 |

https://timmurphy.org/2015/11/09/merging-two-files-in-linux-using-paste/

Script1:
IFS="|";

animals="dog|cat|fish|squirrel|bird|shark";
animalArray=($animals);

for ((i=0; i<${#animalArray[@]}; ++i));
do     
    echo "animal $i: ${animalArray[$i]}"; 
done


Script2:
IFS="|";

animals="animal list|dog,cat,fish,squirrel,bird,shark";
animalArray=($animals);

echo "${animalArray[0]}"-"${animalArray[1]}"; 

# Spark
https://stackoverflow.com/questions/46999601/re-run-spark-jobs-on-failure-or-abort
https://nofluffjuststuff.com/blog/mark_johnson/2016/02/5_steps_to_get_started_running_spark_on_yarn_with_a_hadoop_cluster
https://www.quora.com/How-is-fault-tolerance-achieved-in-Apache-Spark
https://data-flair.training/blogs/fault-tolerance-in-apache-spark/
http://spark.apache.org/docs/latest/api/scala/index.html#org.apache.spark.sql.Dataset

*CreateOrReplaceTempView vs CreateGlobalTempView*
There is a difference between CreateOrReplaceTempView and createGlobalTempView, CreateorReplaceTempView is used when you want to store the table for a particular spark session and createGlobalTempView is used when you want to share the temp table across multiple spark sessions.


*Case Sensitivity*
By default Spark is case insensitive; however, you can make Spark case sensitive by setting the configuration:

-- in SQL
set spark.sql.caseSensitive true

*ifnull, nullIf, nvl, and nvl2*
There are several other SQL functions that you can use to achieve similar things. ifnull allows you to select the second value if the first is null, and defaults to the first. Alternatively, you could use nullif, which returns null if the two values are equal or else returns the second if they are not. nvl returns the second value if the first is null, but defaults to the first. Finally, nvl2 returns the second value if the first is not null; otherwise, it will return the last specified value (else_value in the following example):

-- in SQL
SELECT
  ifnull(null, 'return_value'),
  nullif('value', 'value'),
  nvl(null, 'return_value'),
  nvl2('not_null', 'return_value', "else_value")
FROM dfTable LIMIT 1
+------------+----+------------+------------+
|           a|   b|           c|           d|
+------------+----+------------+------------+
|return_value|null|return_value|return_value|
+------------+----+------------+------------+
Naturally, we can use these in select expressions on DataFrames, as well.

*fill*
Using the fill function, you can fill one or more columns with a set of values. This can be done by specifying a map—that is a particular value and a set of columns.

For example, to fill all null values in columns of type String, you might specify the following:

df.na.fill("All Null values become this string")

We could do the same for columns of type Integer by using df.na.fill(5:Integer), or for Doubles df.na.fill(5:Double). To specify columns, we just pass in an array of column names like we did in the previous example:

// in Scala
df.na.fill(5, Seq("StockCode", "InvoiceNo"))

We can also do this with with a Scala Map, where the key is the column name and the value is the value we would like to use to fill null values:

// in Scala
val fillColValues = Map("StockCode" -> 5, "Description" -> "No Value")
df.na.fill(fillColValues)
