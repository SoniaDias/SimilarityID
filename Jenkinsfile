pipeline {
	  agent any
	  stages {
	    
	    stage('Get code') {
            steps {
                //clean workspace
                cleanWs()
                //get the code to scan
                git 'https://github.com/SoniaDias/SimilarityID'
            }
        }


	    stage ('Initialize') {
	      steps {
	        echo 'cenas maradas'
	      }
	    }





	  }
}
