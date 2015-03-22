Condenser 
==========

### A Steam Web Artefact and Metadata Tool

Condenser is a digital forensics tool for discovering, processing and performing
preliminary analysis of the data left on a computer system after use of the
Steam client’s web browsing features.

 

Features
--------

Condenser has a myriad of tools available to the user.

-   Web artefact discovery

    -   Identifies and discovers the data cache files.

    -   Shows last modified, last accessed and creation dates for all files.

    -   Displays the MD5 and SHA1 hashes for the files.

-   SQLite Cookie Database Parsing

    -   Parses and displays the database that the Steam client stores user
        cookies in.

-   Artefact Imaging

    -   Copies the web artefacts to a user-defined output directory.

    -   Ensures data integrity by comparing the source files MD5 and SHA1 hashes
        to the destination/output files’ hashes.

-   CSV Output

    -   Outputs the web artefact files that have been discovered alongside their
        metadata (name, directory, LA/LM/C dates, MD5 and SHA1 hashes) to CSV
        file for later use by the user.

-   File Carving

    -   Carves a folder of the user’s choice.

    -   Low overhead file carving identifies and carves files of the following
        type:

        -   GIF

        -   JPG

        -   BMP

        -   FLV

        -   HTML

    -   Folder carving is recursive, can be performed on the entire web artefact
        directory in just under 4 seconds for around 300-400 web artefact files.

 

Further Documentation
---------------------

Please visit the wiki for this project for further documentation about the
software.
