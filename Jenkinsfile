pipeline {
  agent {
    docker {
      image 'mono'
    }
    
  }
  stages {
    stage('Step') {
      steps {
        sh '''nuget restore
xbuild /p:Configuration=Release /p:DebugSymbols=false /p:TargetFrameworkVersion="v4.5"'''
      }
    }
  }
}