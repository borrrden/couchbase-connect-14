﻿using System;

namespace cbconnectcli
{
	public static class RawScheduleData
	{

		public static string GetData()
		{
			// SessionId	Date	StartTime	EndTime	Name	Abstract	Track	Presenter1	Company1	Position1	Speaker1Headshot	Presenter2	Company2	Position2	Presenter3	Company3	Position3
			return @"1001	10/6/2014	8:00 AM	6:00 PM	Registration												
1002	10/6/2014	9:00 AM	12:00 PM	Couchbase Server 3.0 Workshop - Developer		Developer										
1003	10/6/2014	9:00 AM	12:00 PM	Couchbase Server 3.0 Workshop - Operations		Operations										
1004	10/6/2014	1:00 PM	2:15 PM	Opening Keynote: Introducing Couchbase Server 3.0			Bob Wiederhold	Couchbase	CEO	http://www.couchbase.com/connect/wp-content/uploads/2014/09/bWiederhold.Headshot.WEB_-e1410455062316-400x400.jpg	Ravi Mayuram	Couchbase	SVP Engineering & Products			
1005	10/6/2014	2:15 PM	2:30 PM	Break												
1006	10/6/2014	2:30 PM	3:15 PM	Building Always-Available Mobile Applications		Mobile	Wayne Carter	Couchbase		http://www.couchbase.com/connect/wp-content/uploads/2014/09/wcarter-400x400.png						
1007	10/6/2014	2:30 PM	3:15 PM	Under the Covers: Couchbase Server Architecture	Come see behind the kimono and attend this grand, technical tour of the Couchbase system architecture.  From the factory floor of the famous ep-engine and presidential voting booths & clockwork of the cluster manager, from the queues of persistence & replication to the dance steps and handoffs of Rebalance & view index maintenance, this is your chance to zoom down a few layers.  Let's follow some requests from through the system!	Architecture	Steve Yen	Couchbase	Co-Founder	http://www.couchbase.com/connect/wp-content/uploads/2014/09/syen-400x400.png						
1008	10/6/2014	2:30 PM	3:15 PM	Talking Tech to the Enterprise: How to Get the Non-Techy’s to Demand NoSQL		Enterprise	Josh Greenbaum	Enterprise Application Consulting 		http://www.couchbase.com/connect/wp-content/uploads/2014/09/speaker_400x400-400x400.png						
1009	10/6/2014	2:30 PM	3:15 PM	Couchbase Server 3.0 Live Demo: Monitoring and Scaling a Couchbase Cluster	Monitoring and Scaling a Live Couchbase Server Deployment: In the world of distributed systems, monitoring (and understanding what you're monitoring) is arguably the most important job an ops team has.  A close second is managing the scale of that system.  In this session we will cover the wide array of metrics that Couchbase has to offer, how to get them out, and what they mean.  We will also cover the specific metrics that lead to the decision to scale out.	Operations	Perry Krug	Couchbase	Solutions Engineer	http://www.couchbase.com/connect/wp-content/uploads/2014/09/krug-400x400.png						
1010	10/6/2014	2:30 PM	3:15 PM	Three Things to Know about Modeling Data for Document Database	""We’re all familiar with modeling data the relational way. When we move to a document database we need to think about things a little differently.<br><br>In this talk we’ll look how best to plan, model and maintain your data using a document database. By diving into real world case studies of Couchbase users, we’ll look at the three main things you need to know about modeling your data in a document database: document design, key design and querying.""	Developer	Matthew Revell	Couchbase	Lead Evangelist	http://www.couchbase.com/connect/wp-content/uploads/2014/09/revell-400x400.png						
1011	10/6/2014	3:20 PM	4:05 PM	Building the Mobile App for Couchbase Connect	What is involved in building a production, cross-platform mobile app using Couchbase-Lite?  Firefly Logic is a custom software development firm, with expertise in Xamarin (for Mobile) and Erlang (for back-end work).  This session will be a “travel log” of our experience learning Couchbase-Lite and building the conference mobile app for Couchbase Connect 2014.  See what we learned, what we found most interesting, and how we plan to leverage Couchbase going forward. 	Mobile	Bryan Hunter	Firefly Logic	CTO	http://www.couchbase.com/connect/wp-content/uploads/2014/09/bryan-1-large.jpg						
1012	10/6/2014	3:20 PM	4:05 PM	Deep Dive: What’s New in Couchbase Server 3.0	Couchbase Server 3.0 and Couchbase Server SDK 2.0 have hundreds of improvements and many hidden gems. Join in for a demo filled guided tour. We will take you through top improvements and detail how we have simplified your life with great availability, scalibility, security and developer features. 	Architecture	Cihan Biyikoglu	Couchbase	Product Manager, Server	http://www.couchbase.com/connect/wp-content/uploads/2014/09/Biyikoglu-400x400.png						
1013	10/6/2014	3:20 PM	4:05 PM	Couchbase Server at Scale at eBay	eBay, Inc.’s Global Data Infrastructure (GDI) organization provides the data infrastructure and frameworks for the massive loads of both eBay.com and PayPal.com web sites. GDI provides several NoSQL solutions, including Couchbase, to meet the highly demanding scalability and availability requirements of its internal customers. In this talk we will cover eBay, Inc.’s soon to be open sourced Open Stack Caching as a Service (CaaS) offering using Couchbase, as well as use cases where Couchbase has been applied at either eBay.com or PayPal.com.	Customer	Chris Kasten	eBay	Chief Architect	http://www.couchbase.com/connect/wp-content/uploads/2014/09/chris-kasten-400x400.png						
1014	10/6/2014	3:20 PM	4:05 PM	Best Practices: Managing a Healthy Couchbase Server Deployment		Operations	Justin Michaels	Couchbase		http://www.couchbase.com/connect/wp-content/uploads/2014/09/michaels-400x400.png						
1015	10/6/2014	3:20 PM	4:05 PM	A N1QL (""Nickel"") for Every Query: Extending SQL to a Document Database	A N1QL (""nickel"") for Every Query: Extending SQL to a Document Database: This session will provide an overview, update, and demo of N1QL, the upcoming query language from Couchbase. In addition to introducing N1QL and the current developer preview available at query.couchbase.com, we will discuss and show exciting new features as N1QL advances towards beta and production release.	Developer	Gerald Sangudi	Couchbase	Software Architect	http://www.couchbase.com/connect/wp-content/uploads/2014/09/Sangudi-400x400.png						
1016	10/6/2014	4:05 PM	4:20 PM	Afternoon Break												
1017	10/6/2014	4:20 PM	5:05 PM	Cross Platform Mobile Development with Telerik	It’s 2014 and it’s insane not to support every mobile platform to reach broadest user base. Let’s keep this simple: Cross-platform Hybrid Mobile development | Your Web Skills | Single codebase | HTML5/JS | Apache Cordova  | AppBuilder | IDEs | Backend Services | Prototype/Test/Deploy/Manage  | Telerik Platform| End-to-End Mobile. Oh, and did we mention the CouchBase Cordova plugin? Join us as we explore the possibilities!	Mobile	Samidip Basu	Telerik	Developer Advocate	http://www.couchbase.com/connect/wp-content/uploads/2014/09/sam-basu.jpg						
1018	10/6/2014	4:20 PM	5:05 PM	Tunable Memory in Couchbase Server 3.0	Couchbase Server supports a multi-threaded object-managed cache that implements memcached-compatible APIs, such as GET, SET, ADD, DELETE, etc. The object-managed cache provides consistent low latency by maintaining key, metadata, and value parts of an object in memory and paging out the value only when an object is ejected from memory. In Couchbase Server 3.0, we extend the cache management to support ejecting an object’s key and metadata along with its value, which reduces the memory footprint significantly and allows an application to make a tradeoff decision between performance and memory overhead. In this presentation, we cover the details of the new cache management and explain the future work that we plan for enhancing the cache management.	Architecture	Chiyoung Seo	Couchbase	Software Architect	http://www.couchbase.com/connect/wp-content/uploads/2014/09/Chiyoung_Seo-400x400.png						
1019	10/6/2014	4:20 PM	5:05 PM	Couchbase @ PayPal	The talk will illustrate PayPal’s usage of Couchbase to light up two distinct infrastructures of Personalization and Server Side Cookies respectively.PayPal’s ecosystem of customers is vast & diverse. It connects with its customer through Omni-channel - across both Online & Retail - touch-points to provide tailored, adaptive and predictive experiences to customer’s needs . The goal is to deliver right experience to the right user at the right time on the right device through Personalization. The talk will showcase how we have architected our Real time Personalization system with key principals of linear scalability, availability, flexibility and extensibility using Couchbase, which provides it both a distributed cache & persistence to manage identities & profiles. This use case will illustrate on how we separate read and write workloads. On the other hand the Cookie Infrastructure  will provide an overview of how to deploy Couchbase in a multi data center scenario. Along the way it will share certain scale, workload patterns and practical tips which might be useful as you plan to adopt it for your enterprise.	Customer	Anil Madan	PayPal	Sr. Director of Engineering	http://www.couchbase.com/connect/wp-content/uploads/2014/09/anil-madan-400x400.png						
1020	10/6/2014	4:20 PM	5:05 PM	Best Practices: Securing a Couchbase Server Deployment	As more and more sensitive information is stored in NoSQL databases, security has become a growing concern. In fact, many organizations are looking at locking down the cluster, encrypting sensitive data using applications, and other third-party technologies to build a defense-in-depth security solution across their application stack. Join this session to learn about existing security features in 3.0 and other ways in which you can protect your Couchbase apps.	Operations	Don Pinto	Couchbase	Product Manager, Server	http://www.couchbase.com/connect/wp-content/uploads/2014/09/d-pinto-400x400.png						
1021	10/6/2014	4:20 PM	5:05 PM	Reactive Programming with RxJava for Efficient Data Access	""Applications which exclusively rely on synchronous data access very often hit a scalability wall when things get slow and their thread pools are exhausted. New paradigms like reactive programming alleviate this and provide extensive toolsets to deal with the ever growing demands of web applications.<br><br>This talk shows how to build scalable and reactive applications by making use of the brand new Couchbase Java SDK 2.0 and the RxJava library. We will also cover stability patterns to increase failure resiliency to be available, 24/365 be it under unexpected load spikes or server failures.""	Developer	Ben Christensen	Netflix	Edge Engineering	http://www.couchbase.com/connect/wp-content/uploads/2014/09/speaker_400x400-400x400.png	Michael Nitschinger	Couchbase	Developer Advocate			
1022	10/6/2014	5:10 PM	5:55 PM	Building Cross Platform Mobile Applications with Xamarin		Mobile	Zack Gramana	Couchbase	Sr. Software Engineer	http://www.couchbase.com/connect/wp-content/uploads/2014/09/sgarma-400x400.png						
1023	10/6/2014	5:10 PM	5:55 PM	Deep Dive into DCP: Streaming Replication Protocol	DCP – Database change protocol is the brand new streaming replications protocol that replaces TAP in Couchbase Server 3.0. DCP comes with a great set of benefits for lowering replication latency and increasing replication throughput. In this talk we will do a deep dive to dissect how DCP enables these efficiencies and powers many core features like replica maintenance, rebalance, view maintenance and cross data center replication. 	Architecture	Mike Wiederhold	Couchbase	Software Engineer	http://www.couchbase.com/connect/wp-content/uploads/2014/09/mweiderhold-400x400.png	Cihan Biyikoglu	Couchbase	Product Manager, Server			
1024	10/6/2014	5:10 PM	5:55 PM	Couchbase @ McGraw Hill		Customer	Chris Tse	McGraw-Hill		http://www.couchbase.com/connect/wp-content/uploads/2014/09/highres_101051892-400x400.jpeg						
1025	10/6/2014	5:10 PM	5:55 PM	Transparent Data Encryption for Couchbase Server	With increased adoption of the Couchbase NoSQL database, companies are also increasingly populating Couchbase Server with sensitive information.  This information can take the form of such things as personally identifiable information (PII), personal health information (PHI), or sensitive customer or internal information.  This information must adhere to regulatory requirements such as PCI and HIPPA, adhere to state and local privacy laws, adhere to customer and partner service level agreements, and have controls in place to prevent insider abuse of the sensitive information.  Vormetric and Couchbase have partnered together to address the data security needs for protecting sensitive information being stored in Couchbase Server. 	Operations	Derek Tumulak	Vormetric	VP Product Management	http://www.couchbase.com/connect/wp-content/uploads/2014/09/derek_tumulak.jpg						
1026	10/6/2014	5:10 PM	5:55 PM	Preview: Native APIs for Querying Couchbase Server with N1QL	If you haven’t heard the news, Couchbase has a hot new query language for querying JSON documents! In this session you will learn about the enhancements that are being added to our SDK’s in support of the N1QL query language, from low level ad-hoc query support to higher level abstractions such as the new Java fluent-interface DSL and .NET Linq2Couchbase provider. These higher level abstractions bring platform idiomatic familiarity to the SDK’s, increase developer productivity and generally make it easier to develop scalable, high performing applications using Couchbase Server for persistence.	Developer	Jeff Morris	Couchbase	Developer Advocate	http://www.couchbase.com/connect/wp-content/uploads/2014/09/jmorris-400x400.png						
1027	10/7/2014	7:00 AM	2:00 PM	Registration												
1028	10/7/2014	7:30 AM	8:30 AM	Breakfast												
1029	10/7/2014	8:30 AM	9:45 AM	Partner Keynote: Lucidworks			Will Hayes	Lucidworks		http://www.couchbase.com/connect/wp-content/uploads/2014/09/Will_Hayes.jpg						
1030	10/7/2014	9:45 AM	10:00 AM	Break												
1031	10/7/2014	10:00 AM	10:45 AM	Cloud Panel	Couchbase will moderate a discussion on how the provisioning of resources to cloud infrastructure, on-premise and public, is changing. The panel will include industry leaders who are driving an application-centric, vendor-agnostic approach by automatining and simplifying the process automating the deployment and management of enterprise applications.	Enterprise	Alex Heneveld	Cloudsoft	CTO	http://www.couchbase.com/connect/wp-content/uploads/2014/09/Alex-Heneveld1.jpg	Rajesh Ramchandani 	CumuLogic	CTO	Monish Sharma 	ElasticBox	VP
1032	10/7/2014	10:00 AM	10:45 AM	Preview: A Next Generation Data Structure and Storage Engine for Databases	B+-tree has been used as one of the main index structures in a database field fore more than four decades. However, typical B+-tree implementations show scalability and performance issues as modern global-scale Web or mobile applications generate huge volumes of data that has not been seen before. Various key-value storage engines with variants of B+-tree, such as log-structured merge tree (LSM-tree) have been proposed to address these limitations. At Couchase, we also have been working on a new key-value storage engine that can provide high scalability and performance, and recently released the beta version of ForestDB, whose main index structure is based on Hierarchical B+-Tree based Trie or HB+-Trie. In this presentation, we introduce ForestDB and discuss why ForestDB can be fitted well for modern big data applications. We also explain various optimizations on ForestDB, which are planned especially for solid-state drives (SSDs).	Architecture	Chiyoung Seo	Couchbase		http://www.couchbase.com/connect/wp-content/uploads/2014/09/Chiyoung_Seo-400x400.png						
1033	10/7/2014	10:00 AM	10:45 AM	Couchbase at AT&T		Customer	Rahul Jain	AT&T	Director of Engineering	http://www.couchbase.com/connect/wp-content/uploads/2014/09/speaker_400x400-400x400.png						
1034	10/7/2014	10:00 AM	10:45 AM	Leveraging AWS Availability Zones and Regions for Global Deployment		Operations	Kyle Lichtenberg	Amazon Web Services		http://www.couchbase.com/connect/wp-content/uploads/2014/09/speaker_400x400-400x400.png						
1035	10/7/2014	10:50 AM	11:35 AM	The Future of Enterprise Application Development		Enterprise	Holger Mueller	Constellation Research		http://www.couchbase.com/connect/wp-content/uploads/2014/09/Holger.png						
1036	10/7/2014	10:50 AM	11:35 AM	Ultra-High Availability and Disaster Recovery with Couchbase Server	Ultra–High Availability and Disaster Recovery with Couchbase Server: Join Anil Kumar for a demo-filled and guided session to learn how to deliver continuously available mission-critical apps across data centers. For today’s mission-critical apps, high availability is no longer a ‘nice to have’ but is essential. Downtime and data loss is unacceptable, resulting in lost revenue. In this session we will cover the wide array of high availability and disaster recovery features available in Couchbase Server.	Architecture	Anil Kumar	Couchbase	Product Manager, Server	http://www.couchbase.com/connect/wp-content/uploads/2014/09/ak-400x400.png						
1037	10/7/2014	10:50 AM	11:35 AM	Session to be announced												
1038	10/7/2014	10:50 AM	11:35 AM	Building Document Driven Applications in Node.js	""What’s different about this generation of web applications? The approach must consider the latency, throughput and interactivity demanded by users for social interaction across both mobile devices and browsers. We will show how Node.js’s programming model makes writing systems to provide this kind of interactivity easy and how Couchbase Server and the Node.js Couchbase SDK support this with a flexible data model.<br><br>Come to this session ready to read code, since a sample game platform will be the basis of a demonstration of these techniques in action. We will show a sample game server, and key aspects of how the system is constructed for simplicity of data modeling, extensibility and scale.""	Developer	Philipp Fehre	Couchbase	Developer Advocate	http://www.couchbase.com/connect/wp-content/uploads/2014/09/fehre-400x400.png						
1039	10/7/2014	11:40 AM	12:25 PM	Comparing the Architecture of Couchbase Server, MongoDB, and Apache Cassandra	""The variety of databases makes it difficult to select the best tool for a particular case. The unbiased 3rd party investigations are extremely hard to get a hold of. Unless you have implemented dozens of of NoSQL databases across large varieties of data-intensive distributed applications, then many technology options are probably a slight enigma. Attendees will get:<br>1) Framework for evaluation of tools and benchmarking NoSQL/Hadoop workloads<br>1.1 Template for setting evaluation & benchmarking goals<br>1.2 Template for evaluation of database tools<br>1.3 Template for profiling workloads<br>2) Example of evaluation & benchmarks from the “war zone”<br>2.1 Example of benchmark results<br>2.2 Example of benchmark goals<br>2.3 Example of benchmark design and scenario<br>2.4 Recommended benchmarking tools<br>2.5 Lessons Learned & making it work for your company""	Enterprise	Renat Khasanshyn	Altoros	CEO	http://www.couchbase.com/connect/wp-content/uploads/2014/09/Renat_Khasanshyn_1060x1060-400x400.jpg						
1040	10/7/2014	11:40 AM	12:25 PM	Deep Dive: Near Real-Time Map / Reduce with Views in Couchbase Server 3.0	Couchbase view engine provides indexing and data aggregation capabilities to Couchbase server with Map/Reduce primitives. Couchbase view engine consumed database changes from on-disk database files from the Couchbase bucket. This limited view engine to operate at disk latency while Couchbase bucket operates at memory speed. In Couchbase 3.0, we extend Couchbase views to make use of Database Change Protocol (DCP) to consume changes from the database and operate at RAM speeds and deliver high throughput and lower indexing latency. Couchbase 3.0 view engine also has improved by rewriting low level index update layer in C. In this presentation, we will cover details of the view engine internal architecture, performance improvements, consistency modes and how it benefits to users.	Architecture	Sarath Lakshman	Couchbase	Software Engineer	http://www.couchbase.com/connect/wp-content/uploads/2014/09/sarath-e1409961115310.jpeg						
1041	10/7/2014	11:40 AM	12:25 PM	Gaining Actionable Insights Out of Big Data		Customer	Tjeerd Brenninkmeijer	Hippo	CMO	http://www.couchbase.com/connect/wp-content/uploads/2014/09/Screen-Shot-2014-09-04-at-6.51.46-PM.png						
1042	10/7/2014	11:40 AM	12:25 PM	Spring Data Couchbase: POJO Centric Data Access for Spring Developers		Developer	Josh Long	Pivotal	Spring Developer Advocate	http://www.couchbase.com/connect/wp-content/uploads/2014/09/speaker_400x400-400x400.png	Michael Nitschinger	Couchbase	Developer Advocate			
1043	10/7/2014	12:25 PM	1:40 PM	Lunch												
1044	10/7/2014	1:40 PM	2:25 PM	Enterprise Reporting: Visualization, BI and ETL with ODBC and JDBC	Couchbase is an amazing high-performance, high-availability data store, with all the additional benefits of a NoSQL solution. But...analyzing your data can be challenging--if not impossible--unless you have a custom application. In this presentation, Simba Technologies engineer Kyle Porter will introduce the ODBC and JDBC connectivity standards, discuss why they're so important when it comes to data analysis, and then walk through the structure of the upcoming Couchbase ODBC and JDBC drivers. He'll also provide an overview of the drivers' capability to interpret SQL and N1QL, then explain how document structure maps to the relational world. Finally, he'll demonstrate the Couchbase ODBC driver in action.	Enterprise	Kyle Porter	Simba Technologies	Solutions Engineer	http://www.couchbase.com/connect/wp-content/uploads/2014/09/Kyle-Porter1-e1410806274258-400x400.jpg						
1045	10/7/2014	1:40 PM	2:25 PM	Enabling High Availability with Multi-Site, Rack-Aware Replication		Operations	Alex Ma	Couchbase	Principal Solutions Engineer	http://www.couchbase.com/connect/wp-content/uploads/2014/09/22639b8.jpg						
1046	10/7/2014	1:40 PM	2:25 PM	How Concur Leveraged Couchbase Server to Help You Get to Here Today	Many of you attending the Couchbase Connect Conference probably used Concur to book your flights. Did you know that at the heart of Concur is a Couchbase Engine that is our user profile store which stores, aggregates, and updates your preferences, all in an effort to deliver a better user experience and provide differentiated services to its myriad business partners? In this session, Denny Lee, senior director of Data Sciences Engineering at Concur will share why and how Concur relies on Couchbase to put data at the center of its business.	Customer	Denny Lee	Concur	Sr. Director							
1047	10/7/2014	1:40 PM	2:25 PM	Building Advanced Systems with Go and Couchbase Server	After a brief introduction to the Go version of the Couchbase SDK this talk will examine several real world applications developed at Couchbase using Go.  First, we will examine cbugg, in many ways a simple web application with CRUD capabilities that stores its data in Couchbase.  Next we examine sync-gateway, the server-side solution for the Couchbase Mobile product line.  Finally, we will examine cbfs, an advanced distributed file store built on top of Couchbase.	Developer	Marty Schoch	Couchbase	Software Engineer	http://www.couchbase.com/connect/wp-content/uploads/2014/09/mschoch-400x400.png						
1048	10/7/2014	2:30 PM	3:15 PM	Live Training: Developing Mobile Apps for .NET		Mobile	Zack Gramana	Couchbase	Sr. Software Engineer	http://www.couchbase.com/connect/wp-content/uploads/2014/09/sgarma-400x400.png						
1049	10/7/2014	2:30 PM	3:15 PM	Best Practices for Deploying to Multiple Data Centers	Building Apps to Survive the Zomber Apocalypse: Join us on an epic journey while we explore best practices for building an application and infrastructure that can survive the most dire of circumstances. Before you go from one datacenter to many data centers, there's things you need to consider for your application. We'll discuss how you can use Couchbase to help take you from a single data center point of failure to being able to handle half the world going dark. 	Customer	Scott Feinberg	WePay	Developer Evangelist	http://www.couchbase.com/connect/wp-content/uploads/2014/09/scott-feinberg-wepay-400x400.jpg						
1050	10/7/2014	2:30 PM	3:15 PM	Session to be announced		Operations										
1051	10/7/2014	2:30 PM	3:15 PM	Integrating Elasticsearch for Real-Time Analytics with Kibana		Developer	David Ostrovsky	Sela Group		http://www.couchbase.com/connect/wp-content/uploads/2014/09/6o7kq8qx-400x400.jpeg						
1052	10/7/2014	3:20 PM	4:05 PM	Live Training: Developing Mobile Apps for iOS		Mobile	Jens Alfke	Couchbase	Architect	http://www.couchbase.com/connect/wp-content/uploads/2014/09/alfke-400x400.png						
1053	10/7/2014	3:20 PM	4:05 PM	Best Practices: Couchbase Indexing in Production		Operations	To be announced	Couchbase								
1054	10/7/2014	3:20 PM	4:05 PM	Session to be announced												
1055	10/7/2014	3:20 PM	4:05 PM	Integrating with Hadoop: Import & Export Data with the Couchbase Sqoop Plugin		Developer	Matt Ingenthron	Couchbase		http://www.couchbase.com/connect/wp-content/uploads/2014/09/ming-400x400.png	Shane Johnson	Couchbase	Product Marketing Manager			
1056	10/7/2014	4:05 PM	4:20 PM	Afternoon Break												
1057	10/7/2014	4:20 PM	5:05 PM	Live Training: Developing Mobile Apps for Android		Mobile	Traun Leyden	Couchbase	Sr. Software Engineer	http://www.couchbase.com/connect/wp-content/uploads/2014/09/speaker_400x400-400x400.png						
1058	10/7/2014	4:20 PM	5:05 PM	Deploying Couchbase Server to Azure		Operations	To be announced	Microsoft								
1059	10/7/2014	4:20 PM	5:05 PM	Global Ad Targeting with Multiple Data Centers		Customer	To be announced	Mirror Image								
1060	10/7/2014	4:20 PM	5:05 PM	Academic Research: Unifying Semi-Structured Query Languages with SQL++		Developer	Yannis Papakonstantinou	University of California, San Diego		http://www.couchbase.com/connect/wp-content/uploads/2014/09/speaker_400x400-400x400.png						
1061	10/7/2014	5:10 PM	5:55 PM	Deep Dive into Couchbase Mobile: Data Synchronization	Learn about the server-side component of Couchbase Mobile. The Couchbase Sync Gateway not only enables document sync between mobile apps and Couchbase Server; it also manages user authentication, data validation, and routing documents between users using a unique ""channel"" mechanism. We'll show how the Sync Gateway is installed and configured, and how to create a sync function to implement your custom app logic with channels.	Mobile	Jens Alfke	Couchbase	Architect	http://www.couchbase.com/connect/wp-content/uploads/2014/09/alfke-400x400.png						
1062	10/7/2014	5:10 PM	5:55 PM	Best Practices: Sizing Your Couchbase Cluster	How many nodes?  That is the million dollar question that we will answer during this session.  Factors like RAM, Disk, CPU and others cross with your specific hardware and workload requirements, resulting in the ideal cluster size.  This session will also discuss some specific architecture and deployment considerations as well as the effects of using different Couchbase features.	Operations	Perry Krug	Couchbase	Solutions Engineer	http://www.couchbase.com/connect/wp-content/uploads/2014/09/krug-400x400.png						
1063	10/7/2014	5:10 PM	5:55 PM	Couchbase @ LinkedIn	LinkedIn’s mission is to connect the world’s professionals to make them more productive and successful. LinkedIn members use the company’s products to get access to people, jobs, news, updates, and insights that help them be great at what they do. To support its goals on an engineering level, LinkedIn services must sustain high levels of QPS while providing data integrity. In this talk, we will discuss how LinkedIn uses Couchbase to help with read scaling and performance of its high impact services. We will also talk about some tooling we have created to integrate Couchbase into our systems and how we operationally manage our Couchbase clusters. Finally, we will explore some future uses of Couchbase within our environment.	Customer	Carleton Miymoto	LinkedIn	Software Engineering Tech Lead	http://www.couchbase.com/connect/wp-content/uploads/2014/09/carletonmiyamoto-e1409862304108-400x400.jpg	Michael Kehoe	LinkedIn	Site Reliability Engineer			
1064	10/7/2014	5:10 PM	5:55 PM	Tuning Couchbase Server, the OS, and the Network for Maximum Performance		Operations	Kirk Kirkconnell	Couchbase	Sr. Solutions Engineer	http://www.couchbase.com/connect/wp-content/uploads/2014/09/Kirk_Kirkconnell-400x400.jpg						
1065	10/7/2014	6:30 PM	9:30 PM	Party												";

		}

	}
}
