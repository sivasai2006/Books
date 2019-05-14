# import the python subprocess module
import subprocess
import time

def file_create():
    sourcefolder = "C:\\CodePlay\\"
    filename = "part-00000_1"
    fileext = ".dat"

    destfolder = "C:\\CodePlay\\test\\"
    fread = open(sourcefolder+filename+fileext, "r")
    if fread.mode == 'r':
        contents = fread.read()
        for i in range(10):
            destfilepath = (destfolder+filename+"%d"%(i+1)+fileext)
            fwrite = open(destfilepath, "w+")
            fwrite.write(contents)
            time.sleep(10)

            # Run Hadoop put command in Python
            (ret, out, err) = run_cmd(['hdfs', 'dfs', '-put', 'local_file', 'hdfs_file_path'])

def run_cmd(args_list):
    """
    run linux commands
    """
    # import subprocess
    #print('Running system command: {0}'.format(' '.join(args_list)))
    proc = subprocess.Popen(args_list, stdout=subprocess.PIPE, stderr=subprocess.PIPE)
    s_output, s_err = proc.communicate()
    s_return = proc.returncode
    return s_return, s_output, s_err

if __name__ == "__main__":
    file_create()
