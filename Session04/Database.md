Database Concept		C# Concept			Description
Table					Class				A table in a database represents a collection of records, similar to a class in C#.
Column					Property			A column in a table maps to a property in a class.
Row						Object				A row in a table represents an instance of a class (an object).
Primary Key				Unique Identifier	A primary key in a database maps to a unique identifier (e.g., Id property).
Foreign Key				Reference			A foreign key in a database maps to a reference to another object in C#.
Schema					Namespace			A schema in a database organizes tables, similar to how namespaces organize classes in C#.


Database Type	C# Type		Description
INT				int			Integer type in both database and C#.
BIGINT			long		Larger integer type.
FLOAT			float		Floating-point number.
DOUBLE			double		Double-precision floating-point number.
DECIMAL			decimal		Precise decimal value, often used for financial data.
BIT				bool		Boolean value (true/false).
DATE			DateTime	Date without time.
DATETIME		DateTime	Date and time.
NVARCHAR		string		Unicode string in the database maps to string in C#.
VARCHAR			string		Non-Unicode string in the database maps to string in C#.
CHAR			string		Fixed-length non-Unicode string.
NCHAR			string		Fixed-length Unicode string.
BINARY			byte[]		Binary data.
UNIQUEIDENTIFIER	Guid	Globally unique identifier (GUID).


national code:	CHAR(10)

Relational Databse
	SQL Server 2017 - 2022
		Postgres/Oracle/Mysql/MariaDB


Code -> db access
	ADO.net
	Micro Framework
		Dapper
	Framework - ORM - Object-Relation Mapping
		Entity Framework
	
