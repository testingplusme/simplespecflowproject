pipeline {
  agent none
  stages {
    stage('Step') {
      steps {
        sh '''sudo apt-get install mono-devel
nuget restore
xbuild /p:Configuration=Release /p:DebugSymbols=false /p:TargetFrameworkVersion="v4.5"'''
      }
    }
  }
}