# __Factory__

#### __An application which a user can use to manage engineers and machinery. October 16, 2020__

#### By _**Emme Buentiempo**_

## Description

This application was created as an Epicodus assignment, with the intent to have it serve as a demonstration of knowledge after the program's eleventh week. For the time being this README will serve as a checklist to demonstrate the satisfaction of all project requirements and objectives. 

## Project requirements:

You've been contracted by the factory of the famous Dr. Sillystringz to build an application to keep track of their machine repairs. You are to build an MVC web application to manage their engineers, and the machines they are licensed to fix. The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. There should be a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it.

User Stories
As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.
As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.
As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.
As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed
As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.
I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.

## Project Objectives:

  * Does at least one of your classes have all CRUD methods implemented in your app? [Complete]
  * Are you able to view both sides of the many-many relationship? For a particular instance of a class, are you able to view all of the instances of the other class that are related to it? [Complete]
  * Is the project in a polished, portfolio-quality state? [Complete]
  * Was required functionality in place by the 5:00pm Friday deadline? [Complete]
  * Does the project demonstrate all of this week's concepts? If prompted, are you able to discuss your code with an instructor using correct terminology? [Complete]

## Previous Objectives

For reference, here are the previous weeks' objectives:
  * Project uses two or more controllers. [Complete]
  * GET and POST requests/responses are used successfully. [Complete]
  * MVC routes follow RESTful conventions. [Complete]
  * Logic is easy to understand. [Complete]
  * Build files are included in .gitignore file and are not be tracked by Git [Complete]
  * Code and Git documentation follows best practices (descriptive variables names, proper indentation and spacing, separation between front and back-end logic, detailed commit messages in the correct tense, and a well-formatted README). [Complete]

## Specs

  1.[x] Engineer index and Machine index and create views. 
    * Input:
    * Output:

  2.[x] Engineer and Machine detail views.
    * Input:
    * Output:

  3.[x] Engineer and Machine edit views.
    * Input:
    * Output:

  4.[x] Engineer and Machine join tables with addengineer and addmachine views.
    * Input:
    * Output:

  5.[x] Removal for engineers, machines, and their joins.
    * Input:
    * Output:
  
  6.[x] Splashpage for all engineers and machines.
    * Input:
    * Output:

## Setup/Installation Requirements

* First, recreate the database schema by connecting to a local instance within MySql Workbench (instal information can be found here if you have not already done so https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
* Query and run the following in a new tab:
  *  CREATE DATABASE `emme_buentiempo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
  *  CREATE TABLE `engineers` (
  *  `EngineerId` int NOT NULL AUTO_INCREMENT,
  *  `EngineerName` longtext,
  *  `EngineerDescription` longtext,
  *  `EngineerStatus` longtext,
  *  PRIMARY KEY (`EngineerId`)
  *  ) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
  *  CREATE TABLE `machines` (
  *  `MachineId` int NOT NULL AUTO_INCREMENT,
  *  `MachineName` longtext,
  *  `MachineDescription` longtext,
  *  `MachineStatus` longtext,
  *  PRIMARY KEY (`MachineId`)
  *  ) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
  *  CREATE TABLE `engineermachines` (
  *  `EngineerMachineId` int NOT NULL AUTO_INCREMENT,
  *  `EngineerId` int NOT NULL,
  *  `MachineId` int NOT NULL,
  *  PRIMARY KEY (`EngineerMachineId`),
  *  KEY `IX_EngineerMachines_EngineerId` (`EngineerId`),
  *  KEY `IX_EngineerMachines_MachineId` (`MachineId`),
  *  CONSTRAINT `FK_EngineerMachines_Engineers_EngineerId` FOREIGN KEY (`EngineerId`) REFERENCES `engineers` (`EngineerId`) ON DELETE CASCADE,
  *  CONSTRAINT `FK_EngineerMachines_Machines_MachineId` FOREIGN KEY (`MachineId`) REFERENCES `machines` (`MachineId`) ON DELETE CASCADE
  *  ) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

Then, to run the application:
* _open terminal_
* _type "cd desktop", then press enter_
* _type "git clone https://github.com/3emme/Factory", then press enter_
* _locate and open directory on desktop named "Factory" with your console of choice_
* _If necessary, update the appsettings.json file with your personal mysql username/password:_
  * {"ConnectionStrings": {"DefaultConnection": "Server=localhost;Port=3306;database=factory;uid={YOUR USERNAME};pwd={YOUR USERNAME}"}
* _(in console) locate and move to the directory inside called OrderTrack_
* _(in console) run $dotnet restore_
* _(in console) run $dotnet build_
* _(in console) run $dotnet run_

## Support and contact details

_Please do not hesitate to contact me at emmettbuentiempo@gmail.com should you have any questions regarding this project_

## Technologies Used

* _C#_

### License

Copyright (c) 2020 **_Emme Buentiempo_**
This software is licensed under the MIT license.