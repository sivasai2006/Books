# Sqoop
http://sqoop.apache.org/docs/1.4.2/SqoopUserGuide.html


# Hive
1. Convert External table to Internal table or vice-versa
   External Tables and Internal Tables (non-External) differ only in the aspect that dropping the table drops meta-data in External          tables, whereas it drops both meta-data and data in the case of Internal tables.
   
   Use the following command to convert an external table to an internal table:

    ALTER TABLE <tablename> SET TBLPROPERTIES('EXTERNAL'='FALSE');

   Use the following command to convert an internal table to an external table:

    ALTER TABLE <tablename> SET TBLPROPERTIES('EXTERNAL'='TRUE');
