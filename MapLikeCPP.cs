// This class mimics the behavior of C++'s std::map where accessing a non-existent key initializes it with a default value.

public class MapLikeCPP<T1, T2> where T1 : notnull
{
    Dictionary<T1, T2> dictionary;

    public MapLikeCPP()
    {
        dictionary = new Dictionary<T1, T2>();
    }

    public T2 this[T1 key]
    {
        get
        {
            if (!dictionary.ContainsKey(key))
                dictionary[key] = default(T2);
            return dictionary[key];
        }
        set
        {
            dictionary[key] = value;
        }
    }
}