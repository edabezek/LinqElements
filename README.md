# Linq Elements
## Single() 
The Linq Single Method is used to returns a single element from a data source or you can say from a sequence. There are two overloaded 
			versions available for this Single Method:

			public static TSource Single<TSource>(this IEnumerable<TSource> source);
			public static TSource Single<TSource>(this IEnumerable<TSource> source,Func<TSource,bool> predicate);

* The first overloaded version of the Single method does not take any parameter. This method simply returns the only element from a sequence.
			If the data source is empty or if the data source contains more than one element, then it throws an exception.
			(InvalidOperationException : Sequence contains no elements or InvalidOperationException : Sequence contains more than one element)

* The second overloaded version of the Single method takes one predicate as a parameter and using this predicate you can specify a condition.
			This method returns the only element from the sequence which satisfied the given condition. In this case, the method will throw an exception
			when any of the following condition is true:
      
				-if data source is empty
				-when giving condition does not satisfy any element in the sequence.
				-if given condition satisfies more than one element

* If you don’t want to throw an exception when the sequence is empty or if the specified condition does not return an element 
			from a sequence then you need to use the SingleOrDefault method.

## SingleOrDefault() 
SingleOrDefault method is very much similar to Single method except that this method will not throw an exception when 
			the sequence is empty or when no element in the sequence satisfied the given condition.Single method, the SingleOrDefault method 
			still throws an exception when the sequence contains more than one matching element for the given condition.
			There are two overloaded versions available for this SingleOrDefaul Method:

			public static TSource SingleOrDefaul<TSource>(this IEnumerable<TSource> source);
			public static TSource SingleOrDefaul<TSource>(this IEnumerable<TSource> source,Func<TSource,bool> predicate);

* First overloaded version of this method does not take any parameter. It simply returns the only 
			element from the sequence. It the sequence is empty then it returns the default value(0 is default value int type) without 
			throwing an exception.

* Second overloaded version of this method you can specify a condition. If the specified condition does not return 
			any data then it will not throw an exception instead it returns the default value.

* Both Single and SingleOrDefault methods in Linq are used to returns a single element from a sequence. But if the sequence is
			empty or if no element is satisfied with the given condition, then the Single method will throw an exception while the SingleOrDefault
			method will not throw an exception instead it returns a default value.

## First() 
Returns the first value found in the collection.
## FirstOrDefault() 
Returns the first value of the data in the collection. If there is no data in the collection, the default value is null.
		  If the data is int, it returns 0.

## ElementAt() 
A single element is returned according to the index number of the data in the collection.
## ElementAtOrDefault 
It ensures that the elements in the array are returned as a single element according to the index order. If the given index does not exist, the default value is null. If the data is int, it returns 0.

## Last() 
Displays the last element of the elements in the collection.
## LastOrDefault() 
It takes the last value of the elements in the collection. If the collection is empty, the default value is null. If the data is int, it returns 0.

## Source  
* http://msdn.microsoft.com/en-us/library/bb342451.aspx
