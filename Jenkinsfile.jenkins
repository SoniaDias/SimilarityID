pipeline {
    agent any

    stages {
        stage('Get code') {
            steps {
                //clean workspace
                cleanWs()
                //get the code to scan
                git branch: 'main', url: 'https://github.com/SoniaDias/SimilarityID'
            }
        }
        stage('SAST Scan') {
            steps(
                [
                $class: 'CxScanBuilder', 
                comment: '', 
                configAsCode: true, 
                credentialsId: '35714087-f0c8-497c-b7b4-71ab804b6980', 
                customFields: '', 
                excludeFolders: '', 
                exclusionsSetting: 'global', 
                failBuildOnNewResults: false, 
                failBuildOnNewSeverity: 'HIGH', 
                filterPattern: '', 
                forceScan: true, 
                fullScanCycle: 10, 
                groupId: '1', 
                password: '{AQAAABAAAAAQLh8vxI7CDYp/KYfRz16p1S//jgRWOBoNLDdamTjeVso=}', 
                postScanActionId: 1, 
                preset: '36', 
                projectName: 'PipelineTest', 
                sastEnabled: true, 
                serverUrl: 'http://win-hc21vf6uii0/CxWebClient', 
                sourceEncoding: '1', 
                useOwnServerCredentials: true, 
                username: '', 
                vulnerabilityThresholdResult: 'FAILURE', 
                waitForResultsEnabled: true
                ]
                )
        }
    }
}
