# dotnet-automated

Build and Promotion automation with GCP CLoud Builder

Publishing in a App Engine or Cloud Run service named dotnet-automated

Simple Hello World application inside a docker container

-----------------------------------------
Steps
-----
Create a trigger pointing to this repository, choose between App Engine or Cloud Run inside Cloudbuild.yaml

------------------------------

App Engine Permissions
----------------------

    Enable the App Engine API.
    Grant App Engine IAM to the Cloud Build service account:

    In GCP Console, visit the IAM menu.
    In the list of members, look for [YOUR-PROJECT-NUMBER]@cloudbuild.gserviceaccount.com.
    Click on the pencil icon in that row to grant a new role to that account.
    Click Add another role.
    Select App Engine, then click App Engine Admin.
    Click Save.

Cloud Run Permissions
---------------------
    
    Enable the Cloud Run API.
    Grant the Cloud Run Admin role to the Cloud Build service account:
    In GCP Console, access the IAM menu.
    In the list of members, locate and select [PROJECT_NUMBER]@cloudbuild.gserviceaccount.com.
    Click on EDIT (pencil) button in that row to grant a new role to that account.
    Click Add another role.
    Select Cloud Run, and then Cloud Run Admin.
    Click Save.
    Grant the IAM Service Account User role to the Cloud Build service account on the Cloud Run runtime service account:
    In GCP Console, access the Service Accounts menu.
    In the list of members, locate and select [PROJECT_NUMBER]-compute@developer.gserviceaccount.com.
    Click SHOW INFO PANEL in the top right corner.
    In the Permissions panel, click the Add Member button.
    Enter the Cloud Build service account ([PROJECT_NUMBER]@cloudbuild.gserviceaccount.com) in the New Member input field.
    In the Role dropdown, select Service Accounts, and then Service Account User.
    Click Save.
    Create a build config file that uses gcloud beta run deploy:

Source: https://cloud.google.com/cloud-build/docs/configuring-builds/build-test-deploy-artifacts