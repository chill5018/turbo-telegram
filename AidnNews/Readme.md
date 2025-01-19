# AidnNews

A Backend for the Aidn NEWS Calculator:

Written in C# + .Net

Architecture: Ports and Adapters approach for scalability within larger projects. (AidnNews/Domain is the entry point)


## Future Improvements:
* Better defaults for Swagger UI
* DB for Storing customer scores and charting for monitoring trends


* PostgreSQL and how that would be modelled.

If we wanted to track a user's News Score over time.

1. We would need to implement authentication and a user table
  a. contains all basic user information (name, id, email, etc. )
2. We would have another table with User Scores (PK: ID_Measurements, FK: UserId)
  a. this would allow us to get all of a users data over time
  b. It should contain: the measurements, score, and date of entry.

Retrieving historical data of a user:
 PK and FK are by default indexed, which means we can leverage this for quickly getting all of the users measurements by a particular userId, and in return plot that on a graph in a dashboard.


Notes:
* Testing Suite is not complete, only tested a couple of the entities and the service layer

* I have not implemented the controller tests, as this would take a bit of time to investigate.
