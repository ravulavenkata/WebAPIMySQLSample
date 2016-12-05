--------------------------------------------------------
-- This is InSite application database Seed Script.
-- -----------------------------------------------------


insert into `WebAPIMySQLSampleDb`.`status`(StatusCode,StatusName)
values("1","Active"),
("2","InActive"),
("3","Pending"),
("4","Cancelled"),
("5","Rejected"),
("6","TBD"),
("7","Created"),
("8","Updated"),
("9","Deleted"),
("10","Yet To View"),
("11","Viewed"),
("12","InProgress"),
("13","Delayed"),
("14","At Risk");

insert into `WebAPIMySQLSampleDb`.`priority`(PriorityCode,PriorityName)
values("1","Low"),
("2","Medium"),
("3","High"),
("4","Today");


insert into `WebAPIMySQLSampleDb`.`company`(CompanyUniqueID,CompanyName,CompanyAddress,CompanyCity,StatusId)
values("9c85260d-d3f7-4955-a788-1a575078d1a1","Sava One","2311 Texas Dr Suite 105","Irving","1");
insert into `WebAPIMySQLSampleDb`.`company`(CompanyUniqueID,CompanyName,CompanyAddress,CompanyCity,StatusId)
values("4fb17b3e-62bb-4c71-9cb6-27b6a14d6dea","Rosendin Electric","San Jose Office Street","San Jose","1");


insert into `WebAPIMySQLSampleDb`.`accounts`(AccountUniqueId, AccountName, AccountAddress, AccountCity, AccountStateId, CompanyUniqueId, StatusId)
values("c0fda736-5789-4144-94c9-52949ca5b022","Company-1 Account-1","2311 Texas Dr Suite 105","Irving","1","9c85260d-d3f7-4955-a788-1a575078d1a1","1");

insert into `WebAPIMySQLSampleDb`.`accounts`(AccountUniqueId, AccountName, AccountAddress, AccountCity, AccountStateId, CompanyUniqueId, StatusId)
values("2d440cb7-93b9-4f2b-b4d5-0955177c2a00","Company-2 Account-1","San Jose HQ Street For Trial","San Jose","1","4fb17b3e-62bb-4c71-9cb6-27b6a14d6dea","1");






insert into `WebAPIMySQLSampleDb`.`employee`
(AccountUniqueId,EmployeeUniqueId,
EmployeeFirstName,EmployeeLastName,EmployeeUserName,
EmployeePassword,EmployeePasswordSalt,
StatusId,IsPasswordReset)

values("c0fda736-5789-4144-94c9-52949ca5b022","a003d12b-e28b-4332-b1e2-e6ab9eb00014",
"John","Smith1","jsmith1",
"e1f38962d8d2c8cd630f15622d3de102","zovovubi",
"2","0"),
("c0fda736-5789-4144-94c9-52949ca5b022","c28f789a-c11a-4e8a-b00e-1d880a6ec69a",
"Tim","Cook","tcook",
"e1f38962d8d2c8cd630f15622d3de102","zovovubi",
"2","0"),
("c0fda736-5789-4144-94c9-52949ca5b022","af382d12-b8ff-4fed-a587-ef774b8e1f51",
"Gang","Foreman","tgforeman",
"e1f38962d8d2c8cd630f15622d3de102","zovovubi",
"2","0"),
("c0fda736-5789-4144-94c9-52949ca5b022","af382d12-b8ff-4fed-a587-ef774b8e1fC1",
"Crew1","Person","cperson1",
"e1f38962d8d2c8cd630f15622d3de102","zovovubi",
"2","0"),
("c0fda736-5789-4144-94c9-52949ca5b022","af382d12-b8ff-4fed-a587-ef774b8e1fC2",
"Crew2","Person","cperson2",
"e1f38962d8d2c8cd630f15622d3de102","zovovubi",
"2","0"),
("c0fda736-5789-4144-94c9-52949ca5b022","af382d12-b8ff-4fed-a587-ef774b8e1fC3",
"Crew3","Person","cperson3",
"e1f38962d8d2c8cd630f15622d3de102","zovovubi",
"2","0"); 