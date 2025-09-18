pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // ye step automatic repo clone karega
                checkout scm
            }
        }

        stage('Restore') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build --configuration Release'
            }
        }

        stage('Publish') {
            steps {
                bat 'dotnet publish -c Release -o published'
            }
        }

        stage('Deploy to IIS') {
            steps {
                bat '''
                    xcopy published C:\\inetpub\\wwwroot\\EmployeeManagement /E /I /Y
                    iisreset
                '''
            }
        }
    }
}
