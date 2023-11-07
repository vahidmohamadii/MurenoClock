
using json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

model model = new model();
model model2 = new model();
model model3 = new model();
using (StreamReader file = new StreamReader("C:/Users/Lenovo/source/repos/json/json/json.json"))
{


    int id = 1;
    string q = file.ReadToEnd();


    JToken n = (JToken)JsonConvert.DeserializeObject<object>(q);
    var w = n.Children().Count();
    foreach (var item in n)
    {
        model.Id = id++;
        model.Name = item.Path;
        model.Value = item.First().ToString();

        if (item.Children().Count() > 0)
        {
            foreach (var item2 in item)
            {
                model2.Id = id++;
                model2.Name = item2.Path;
                model2.Value = item2.First().ToString();

                if (item2.Children().Count() > 0)
                {
                    foreach (var item3 in item2)
                    {

                        model3.Id = id++;
                        model3.Name = item3.Path;
                        model3.Value = item3.First().ToString();
                    }
                }
            }
        }

    }


}

Console.WriteLine("Name : " + model.Name + "   " + "Value : " + model.Value +
    "/n" + "Name : " + model2.Name + "   " + "Value : " + model2.Value +
                    "/n" +
                    "Name : " + model3.Name + "   " + "Value : " + model3.Value

                    );

Console.ReadLine();
