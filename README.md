# UVRPMigrationTool
Tool to make inventory migration and car reimbursements easier.

This will only work properly if the total inventory weight for gang stash is increased with enough weight and slots to support moving everything. 

This program will 

-Read the players from the old database and compile their inventories and cars. 
-Calculate the total value of a players cars on the old database and then subtract the balance of any cars that are on finance so they only get back money they paid. 
-Combine all of their inventories into a single inventory and remove any items that are not in the new items file automatically from the new inventory. 
-Re-slots the items in the inventory so none of the items overlap with each other
-Combine the new stash from the current live database with the reimbursement stash from the old database into a single stash. 
-Pulls current stash ID from new database so it knows where to put the new stash.
-Can update each player one at a time with a single click to reimburse both the cash from cars and the inventory items or provides data needed on screen if more comfortable putting it in manually.
UPDATE 07/03/2023: Now automatically pulls the players savings account information and adds it to the total amount to be reimbursed.
