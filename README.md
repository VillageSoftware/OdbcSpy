# ODBC Spy

Excel used to have a little component for querying ODBC connections with SQL, but it went away in newer versions. So here's a replacement which will let you send SQL down an ODBC connection and get back some CSV data. From there, if you want to put it in Excel, you can use the `Data\From Text` feature in Excel.

The title bar will show you which version you're running (in terms of bitness/architecture) to prevent confusion with 32/64 bit ODBC connections.

## Download

To download, go to [Releases](https://github.com/VillageSoftware/OdbcSpy/releases)

## Instructions

When you open the program, it will suggest a connection string format to you, like `DSN=DriverName;UID=username;pwd=password`. The DriverName should be replaced with a Name of a Driver which can be found in the System DSN tab of your ODBC Data Source Administrator. Not all connections require credentials. You need to run the version of OdbcSpy which matches the bitness (32/64) of the particular connection you hope to use.

## License

MIT, see [License.txt](LICENSE.txt)

![Screenshot](odbc-spy-1.png)

