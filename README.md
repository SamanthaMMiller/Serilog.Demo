# Serilog.Demo
Some TDD based NUnit tests that use Serilog to log to both AWS ElasticSearch (using Kibana for log display & filtering), and Seq - to compare these two products related to the analysis, display, and filtering of structured log data). And along the way, we also use AutoFixture to make the creation of dummy data to go into our log messages easier.

Some related links to look at: 
* https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-gsg.html
* https://www.elastic.co/guide/en/kibana/current/getting-started.html
* http://www.mpustelak.com/2016/12/log-data-using-serilog-elasticsearch-kibana/
* https://www.codeproject.com/Articles/1041816/Serilog-An-Excellent-Logging-Framework-Integrated
* https://github.com/AutoFixture/AutoFixture/wiki/Cheat-Sheet
* https://github.com/serilog/serilog-sinks-elasticsearch
* https://github.com/serilog/serilog-sinks-seq
* https://github.com/serilog/serilog-settings-appsettings

NOTE: You'll have to set-up your own Elasticsearch cluster, and also install Seq locally, before running this code. 