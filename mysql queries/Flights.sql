SELECT * FROM usflights.flights;
SELECT COUNT(Origin) FROM usflights.flights;
select 
origin, arrdelay, depdelay
from
usflights.flights;
select
origin, colyear, colmonth,
avg(arrtime) as prom_arribades
from
usflights.flights
group by
origin, colyear, colmonth;
select
city, colyear, colmonth,
avg(arrtime) as prom_arribades
from
usflights.flights , usflights.airports
group by
city, colyear, colmonth;
select
uniquecarrier, colyear, colmonth,
sum(cancelled) as total_cancelled
from
usflights.flights
group by
uniquecarrier, colyear, colmonth;
select
tailnum,
sum(distance) as totalDistance
from
usflights.flights
where
tailnum != ""
group by
tailnum
limit 10;
select
uniquecarrier,
avg(arrtime) as avgdelay
from
usflights.flights
where
arrtime > 10
group by
uniquecarrier;

