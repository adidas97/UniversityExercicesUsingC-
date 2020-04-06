using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate TOutput Converter<TInput, TOutput>(TInput input);
    class Convert
    {
        public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array,
                Converter<TInput, TOutput> converter)
        {
            if (converter == null)
                throw new ArgumentNullException(nameof(converter),
                "Converter is null!!!");
            TOutput[] result = new TOutput[array.Length];
            for (int i = 0; i < result.Length; i++)
                result[i] = converter(array[i]);
            return result;
        }
    }
}
