declare @letter char(1);
set @letter = 'a';
print @letter;

declare @name varchar(10);
set @name = 'Lusine';
print @name;

declare @indicator bit;
set @indicator = 0;
print @indicator;

declare @number1 tinyint, @number2 smallint, @number3 int, @number4 bigint;
set @number1 = 216;
set @number2 = 300;
set @number3 = 456356;
set @number4 = 1222333444;
print @number1;
print @number2;
print @number3;
print @number4;

declare @dnumber1 decimal(4, 2), @dnumber2 numeric(10,6), @dnumber3 smallmoney, @dnumber4 money, @dnumber5 float(6), @dnumber6 real;
set @dnumber1 = 33.22;
set @dnumber2 = 6335.65955;
set @dnumber3 = 13555.999;
set @dnumber4 = 1222333444555;
set @dnumber5 = 333.666;
set @dnumber6 = 1222333444555666.777888999;
print @dnumber1;
print @dnumber2;
print @dnumber3;
print @dnumber4;
print @dnumber5;
print @dnumber6;


declare @date1 datetime, @date2 datetime2, @date3 smalldatetime, @date4 date, @date5 time, @date6 timestamp;
set @date1 = '1816-06-16 05:12:33.555';
set @date2 = '0002-05-15 00:12:55.666';
set @date3 = '1993-06-16 11:00:00';
set @date4 = '1566-12-12';
set @date5 = '05:23:33';
print @date1;
print @date2;
print @date3;
print @date4;
print @date5;

