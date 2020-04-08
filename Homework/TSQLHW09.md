#### Roxanna Barahona
#### Homework TSQL CH. 09  
#### March 31, 2020

- Homework Questions

- 1. What is a temporal table?
- it's something that allows you to go back in time. So, if you wanted to see exactly what the situation was, youcoul

- 2. Under what circumstances would you use a temporal table? Temporal tables are in widespread use in
certain kinds of businesses.
- To look up the history of a banking account for example. Any time you would want to look up anything important to
you in history.

- 3. What are the semantics of a temporal table? There are seven of them.
(298)
a. A primary key
b.  Two columns defined as DATETIME2 with any precision, which are non-nullable and represent
the start and end of the row’s validity period in the UTC time zone
c. A start column that should be marked with the option GENERATED ALWAYS AS ROW START
d. An end column that should be marked with the option GENERATED ALWAYS AS ROW END
e. A designation of the period columns with the option PERIOD FOR SYSTEM_TIME (<startcol>, <endcol>)
f. The table option SYSTEM_VERSIONING, which should be set to ON
g. A linked history table (which SQL Server can create for you) to hold the past states of modified rows

- 4. How do you search a history table?
- you run a query against the main table

- 5. How do you modify a history table?
- Modifying temporal tables is similar to modifying regular tables. You modify only the current table
with INSERT, UPDATE, DELETE, and MERGE statements. You modify the current table.

- 6. How do you delete date from a history table? Why would you want to delete data from a history table?
- Use the 'DELETE' command. An employee is fired or the need to track something is no longer needed. 'DELETE' the row or drop the column

- 7. How do you search a history table?
-  Query the name of what you want. It's similar to modifying regular tables. Same as question 4.

- 8. How do you query all data from both a history file and the current data?
-  You utilize the 'GO' command, between to different queries.
- FOR SYSTEM TIME ALL

- 9. How do you drop a temporal table?
- Similar to a regular table you use the syntax 'DROP TABLE IF EXISTS' followed by the table_Name.
