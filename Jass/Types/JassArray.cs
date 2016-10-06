using System;

namespace Jass
{
	public class JassArray<T> 
	{

		T[] _internal = new T[0];

		public void Clear()
		{
			Array.Resize(ref _internal, 0);
		}

		public bool Contains(T value)
		{
			return IndexOf(value)!=-1;
		}

		public int IndexOf(T value)
		{
			int itemIndex = -1;
			for (int i = 0; i < Length; i++)
			{
				if (_internal[i].Equals(value))
				{
					itemIndex = i;
					break;
				}
			}
			return itemIndex;
		}

		public int Length
		{
			get
			{
				return _internal.Length;
			}
		}

		public T this[int key]
		{
			get
			{
				return _internal[key];
			}
			set
			{
				int newSize = Math.Max(Length, key+1);
				if (newSize != Length)
				{
					Array.Resize(ref _internal, newSize);
				}
				_internal[key] = value;
			}
		}
	}
}
