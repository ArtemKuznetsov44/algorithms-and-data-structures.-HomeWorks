namespace HomeTask__4___1_
{
    class TestForArray
    {
        // Тестирование для массива строк.
        public static void Start(string[] arr, string substring)
        {
            foreach(string value in arr) 
            {
                if(value.Equals(substring))
                {
                    break; 
                }
            }
        } 
    }
}
