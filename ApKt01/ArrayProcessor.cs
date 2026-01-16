namespace ApKt01;

public static class ArrayProcessor
{
	public static void IncrementListElements(IList<int> array)
	{
		Parallel.For(0, array.Count, i => { array[i] += 1; });
	}
}
