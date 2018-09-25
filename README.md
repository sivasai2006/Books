# Sqoop
http://sqoop.apache.org/docs/1.4.2/SqoopUserGuide.html

1. Use — P Option with Sqoop Command
   Sqoop supports reading passwords via standard input (STDIN). You can use this option by with help of — P options with sqoop command. Sqoop will prompt you for the password.

   Below is the example of using — P option:

   ```$sqoop import --connect jdbc:netezza://localhost/MYDB \```
   ```--username testuser -- P --table ORDERS```

2. Use – password-file Option with Sqoop Command
   Best Approach secure your password and execute Sqoop command without getting password prompt is to use the — password-file option. You can keep the password file in the system where you are executing the Sqoop command or you can copy that file to HDFS directory and use the path in the sqoop command. It is better if you create the file in HDFS system so that that will be shared across multiple users.

   Create a .password file
   
   ```$echo -n "myPassword" > fileName.password```

   ```$hdfs dfs -put .password /user/$USER/```
   
   ```$hdfs dfs -chmod 400 /user/$USER/fileName.password```
   
   Use that .password file in sqoop import
   
   ```$sqoop import --connect jdbc:netezza://localhost/MYDB ```
   
   ```--username testuser \```
   
   ```--password-file ${user.home}/fileName.password```
   
   ```--table ORDERS \```

# Hive
1. Convert External table to Internal table or vice-versa
   External Tables and Internal Tables (non-External) differ only in the aspect that dropping the table drops meta-data in External          tables, whereas it drops both meta-data and data in the case of Internal tables.
   
   Use the following command to convert an external table to an internal table:

    ```ALTER TABLE <tablename> SET TBLPROPERTIES('EXTERNAL'='FALSE');```

   Use the following command to convert an internal table to an external table:

    ```ALTER TABLE <tablename> SET TBLPROPERTIES('EXTERNAL'='TRUE');```
