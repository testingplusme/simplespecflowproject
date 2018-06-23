pipeline {
  agent any
  stages {
    stage('Build code and run test') {
      steps {
        script {
          node {
            stage 'Checkout'
            checkout scm

            stage 'Build'

            bat 'nuget restore SimpleDI.sln'
            bat "\"${tool 'msbuild'}\" SimpleDI.sln /p:Configuration=Release"

            stage 'Run Tests'

            bat 'nunit3-console SimpleDI\\bin\\Release\\SimpleDI.dll'
          }
        }

      }
    }
  }
}