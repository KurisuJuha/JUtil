# JUtil

## JUtilとは

Unity用のオレオレライブラリ

## 使い方

### DataWriter

DataWriterは様々な型をbytes配列に変換できるクラスです。

``` c#
DataWriter writer = new DataWriter();
writer.Put(6);
Console.WriteLine(string.Join(',', writer.GetData()));
```

結果

``` 結果
6,0,0,0
```

### DataReader

DataReaderはbytes配列を様々な型に変換できるクラスです。

``` c#
byte[] value = new byte[]{
    6,
    0,
    0,
    0,
};

DataReader reader = new DataReader();
Console.WriteLine(reader.GetInt());
```

結果

``` 結果
6
```

### BytesUtil

BytesUtilは拡張メソッドにより簡単にbytes配列に変換することができたり、bytes配列から元の値に変換したりすることができるクラスです。

``` c#
int a = 5;

bytes[] b = a.GetBytes();

Console.WriteLine(string.Join(',', b));

int c = b.ToInt();

Console.WriteLine(c);
```

結果

``` 結果
5,0,0,0
5
```
