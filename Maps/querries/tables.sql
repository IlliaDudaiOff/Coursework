drop table if exists markers;
drop table if exists users;


create table users(
    user_id serial primary key,
    user_name varchar(50) not null,
    user_password varchar(16) not null,
    home_point_long float,
    home_point_latit float
);

create table markers(
    user_id serial references users(user_id),
    marker_name varchar(100),
    longitude float not null,
    latitude float not null
);
insert into users(user_name, user_password) values ('user','password');
select * from users;
insert into users(user_name, user_password) values ('user1','password');
select * from users;

SELECT DATE '2001-09-28' + 7;