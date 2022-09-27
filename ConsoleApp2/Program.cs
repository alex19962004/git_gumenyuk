namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value ...");
            string value = Console.ReadLine();

            Console.WriteLine("Type of value ...");
            string typeOfValue = Console.ReadLine();

            object valueObject = 0;
            {
                switch (typeOfValue)
                {
                    case "sbyte":
                        try
                        {
                            sbyte valueSbyte = checked(Convert.ToSByte(value));
                            valueObject = valueSbyte.GetType().Name;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Error! Invalid value entered!!!");
                        }
                        break;


                    case "bool":
                        try
                        {
                            bool valueBool = checked(Convert.ToBoolean(value));
                            valueObject = valueBool.GetType().Name;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Error! Invalid value entered!!!");
                        }
                        break;


                    case "short":
                        if (short.TryParse(value, out short shortValue))
                        {
                            short valueShort = Convert.ToInt16(value);
                            valueObject = valueShort.GetType().Name;
                        }
                        else
                        {
                            Console.WriteLine("Error! Invalid value entered!!!");
                        }
                        break;


                    case "ushort":
                        try
                        {
                            ushort valueUshort = checked(Convert.ToUInt16(value));
                            valueObject = valueUshort.GetType().Name;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Error! Invalid value entered!!!");
                        }
                        break;

                    case "int":
                        try
                        {
                            int valueInt = checked(Convert.ToInt32(value));
                            valueObject = valueInt.GetType().Name;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Error! Invalid value entered!!!");
                        }

                        break;

                    case "uint":
                        uint valueUint = Convert.ToUInt32(value);
                        valueObject = valueUint.GetType().Name;
                        break;

                    case "long":
                        long valueLong = Convert.ToInt64(value);
                        valueObject = valueLong.GetType().Name;
                        break;

                    case "ulong":
                        ulong valueUlong = Convert.ToUInt64(value);
                        valueObject = valueUlong.GetType().Name;
                        break;

                    case "float":
                        float valueFloat = Convert.ToSingle(value);
                        valueObject = valueFloat.GetType().Name;
                        break;

                    case "double":
                        double valueDouble = Convert.ToDouble(value);
                        valueObject = valueDouble.GetType().Name;
                        break;

                    case "decimal":
                        decimal valueDecimal = Convert.ToDecimal(value);
                        valueObject = valueDecimal.GetType().Name;
                        break;

                    case "string":
                        string valueString = Convert.ToString(value);
                        valueObject = valueString.GetType().Name;

                        break;



                    default:
                        Console.WriteLine("Error! Incorrect input type value");
                        break;
                }

                Console.WriteLine("The input value is" + " " + value + ", " + "type is" + " " + valueObject);
            }


            /*Console.WriteLine("Enter value ...");
            string value = Console.ReadLine();

            Console.WriteLine("Type of value ...");
            string typeOfValue = Console.ReadLine();

            {
                switch (typeOfValue)
                {
                    case "sbyte":
                        try
                        {
                            sbyte valueSbyte = Convert.ToSByte(value);
                            Console.WriteLine($"Value is: {valueSbyte}, type is: {valueSbyte.GetType()}");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Error! Invalid value entered!!!");
                        }
                        break;


                    case "bool":
                        try
                        {
                            bool valueBool = (Convert.ToBoolean(value));
                            Console.WriteLine(valueBool.GetType());
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Error! Invalid value entered!!!");
                        }
                        break;

                    default:
                        Console.WriteLine("Error! Incorrect input type value");
                        break;*/
        }
    }
}