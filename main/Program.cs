string [] arr = new string[] {"fst", "second", ":-)"};
List<string> list = new List<string>();
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length < 4){
        list.Add(arr[i]);
    }
}
string [] new_arr = new string[list.Count];
for (int i = 0; i < list.Count; i++)
{
    new_arr[i] = list[i];
}
Console.Write(string.Join(", ", new_arr));

