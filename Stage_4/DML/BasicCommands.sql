use Monitoring
select * from Company


select Industry, count(Industry) from Company
where Industry is not null and len(Industry) > 1
group by Industry

select [Name], DateOfFoundation from Company
where Industry = 'Information technologies' and DateOfFoundation > 2010
order by DateOfFoundation desc