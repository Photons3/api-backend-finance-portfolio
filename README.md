# How to run the backend API

## Prerequisite (Install all required dependency)
1. SQL Server Express 2022 [link](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
2. SQL Server Management Studio [link](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
3. .Net Core SDK v8 [link](https://dotnet.microsoft.com/en-us/download)
4. Free Stock Market API Key [get API Key Here](https://site.financialmodelingprep.com/developer/docs)
5. Clone the front end repository [Github](https://github.com/Photons3/finance-portfolio-frontend)

## API Backend Startup
1. Open SQL Server Management Studio and Connect to a Database Server
2. Create a new database and add a friendly name to it
3. Run this query in your created database
   
   ``select
    'data source=' + @@servername +
    ';initial catalog=' + db_name() +
    case type_desc
        when 'WINDOWS_LOGIN' 
            then ';trusted_connection=true'
        else
            ';user id=' + suser_name() + ';password=<<YourPassword>>'
    end
    as ConnectionString
from sys.server_principals
where name = suser_name()``

5. Copy the Connection String at the bottom of the screen.
6. On the root directory of the project open `appsettings.json` file
7. Paste the connection string that you copy from SSMS to the Default Connection key
8. Go to FMP and copy your API Key and paste it to FMP key in `appsettings.json` and hit save
9. Run `dotnet tool install --global dotnet-ef` on the terminal and press enter
10. Run `dotnet ef migrations add initialcreate` on the terminal in the root directory
11. Run `dotnet watch run` to run the development server
12. Run the frontend website together with the backend API
