using System;

namespace CSharpIntermediateToAdvance
{
    partial class Program
    {

        static void Main(string[] args)
        {
            //Section 5 Exercise
            var instruction = "create a table Student";
            var sqlConnection = new SqlConnection("Make a connection");
            var oracleConnection = new OracleConnection("Make a connection");
            var dbCommand = new DbCommand(instruction);
            dbCommand.Execute();
            dbCommand = new DbCommand(oracleConnection, instruction);
            dbCommand.Execute();
        }


    }

    //.....DB Commands
    public class DbCommand
    {
        private readonly string _instruction;
        private readonly DbConnection _dbConnection;
        private SqlConnection sqlConnection;
        private string instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (string.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentNullException("These are Instructs:");
            }
            _instruction = instruction;
            this._dbConnection = dbConnection ?? throw new ArgumentNullException("DbConnection");

        }

        public DbCommand(string instruction)
        {
            this.sqlConnection = sqlConnection;
            this.instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Run: {0}", _instruction);
            _dbConnection.Close();
        }
    }
    //...........Class DB Connector
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("You must need to enter a valid string", "connectionString");
            }

            this._connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }

    //Derived Class DBConnector
    public class OracleConnection : DbConnection
    {
        private bool _status;
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void Open()
        {
            if (_status)
            {
                Console.WriteLine("Connection is already is open.");

            }
            else
            {
                Console.WriteLine("Opening Oracle Connection.");
                _status = true;
            }
        }

        public override void Close()
        {
            if (_status)
            {
                Console.WriteLine("Closing Oracle Connection.");
                _status = false;
            }
            else
            {
                throw new InvalidOperationException("Before closing a connection you have to open it first.");
            }
        }
    }
    //.......End...............
}



