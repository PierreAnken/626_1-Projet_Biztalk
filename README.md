# HEVS_S8_Projet_Biztalk

To reproduce the test envrionnement:

1) Clone the repository https://github.com/PierreAnken/HEVS_S8_Projet_Biztalk
or extract this archive file.

2) Unzip Process_folders.zip in the same folder to get following path 
Desktop\HEVS_S8_Projet_Biztalk\Process_folder\ftp_local
The folder ftp_remote is only a template for a remote ftp and is not needed.

3) Run the sql script createDB.sql from folder Database into your local sql server manager

4) Configure a local ftp with Filezilla with following configuration:
Host: localhost
User: admin 
Password: empty

Root shared folder: 
HEVS_S8_Projet_Biztalk\Process_folder\ftp_local

Read only shared folders: 
HEVS_S8_Projet_Biztalk\Process_folder\ftp_local_readonly\ftp_emergency_out_readonly  
alias \ftp_emergency_out_readonly

HEVS_S8_Projet_Biztalk\Process_folder\ftp_local_readonly\ftp_badge_maker_out_readonly_CardCreation 
alias \ftp_badge_maker_out_readonly_CardCreation

HEVS_S8_Projet_Biztalk\Process_folder\ftp_local_readonly\ftp_badge_maker_out_readonly_AccessRightCreation 
alias \ftp_badge_maker_out_readonly_AccessRightCreation

5) Use the messages samples from folder Message_Sample in the related local or ftp folder to get the process started 
