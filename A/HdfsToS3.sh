#!/bin/bash
###########################################################################################
#  Program      :
#
#  Input        :
#
#  Output Paramerers    :
#
#  Developer    :
#
#  Date :
#
#  Modification History
#  Version              Mod By                  Mod Date                Comments
#-----------------------------------------------------------------------------------------
#  1.0                  Sivakumar               08-July-19            Initial Version
#----------------------------------------------------------------------------------------
#
#
#------------------------------------------------------------------------------------------
#
#
#
##########################################################################################


##########################################################################################
#Environment Variables
##########################################################################################

auditfiles=`hive -S -e "select tph_audit_log.processedfiles from hivedb.tph_audit_log where TO_DATE(tph_audit_log.processeddate)=DATE_SUB(CURRENT_DATE,0);"`

aws_access_key_id=`cat /hadoop/prod/framework/utilities/testscripts/aws_credentials | grep aws_access_key_id | cut -d ' ' -f3`
aws_secret_access_key=`cat /hadoop/prod/framework/utilities/testscripts/aws_credentials | grep aws_secret_access_key | cut -d ' ' -f3`
s3_bucket_name=s3b-production-bcbs


#########################################################################################
#Distcp the compressed archive folder to S3 for files older than two days from current date in tph_audit
##########################################################################################

for processedfiles in $auditfiles; do
    IFS=',' read -ra processedfile <<< "$processedfiles"
    for filepath in "${processedfile[@]}"; do
        echo "$filepath"

        filename=${filepath##*/}
        echo "$filename"
		
		hadoop distcp -Dfs.s3a.server-side-encryption-algorithm=AES256 -Dfs.s3a.access.key=$aws_access_key_id -Dfs.s3a.secret.key=$aws_secret_access_key -strategy dynamic $filename s3a://s3b-production-bcbs$filename

    done
done
