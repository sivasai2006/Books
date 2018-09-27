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
