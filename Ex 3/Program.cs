namespace Ex_3
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter number of songs: ");
            int num = Convert.ToInt32(Console.ReadLine());
            List<Song> listSongs = new List<Song>();
            for (int i = 0; i < num; i++)
            {
                Console.Clear();
                Console.Write("Enter data: ");
                String str = Console.ReadLine();
                String[] vs = str.Split(new Char[] { '_' });
                Song song = new Song(vs[0], vs[1], vs[2]);
                listSongs.Add(song);
            }
            Console.Clear();
            Console.Write("Enter type list: ");
            String type_list = Console.ReadLine();
            foreach (Song song in listSongs)
            {
                if (type_list == song.type_list)
                {
                    Console.WriteLine(song.name);
                }
                else if (type_list == "All")
                {
                    Console.WriteLine(song.name);
                }
            }
            Console.ReadLine();
        }
    }

}
