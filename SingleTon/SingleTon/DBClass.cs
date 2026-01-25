namespace SingleTon
{
    internal class DBClass
    {
        private static DBClass instance = null;

        String dbUrl;
        String userName;
        String password;

        private static object syncLock = new object();
        public static DBClass getInstance()
        {
            if (instance == null)
            {
                Console.WriteLine("DB accessed when null.");
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new DBClass();
                        Console.WriteLine("DB created.");
                    }
                }
            }
            Console.WriteLine("DB returned.");
            return instance;
        }

        private DBClass()
        {

        }


        public String getDbUrl()
        {
            return dbUrl;
        }

        public void setDbUrl(String dbUrl)
        {
            this.dbUrl = dbUrl;
        }

        public String getUserName()
        {
            return userName;
        }

        public void setUserName(String userName)
        {
            this.userName = userName;
        }

        public String getPassword()
        {
            return password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }
    }
}
