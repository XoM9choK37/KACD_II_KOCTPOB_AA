alter table students
add constraint phonelength
check (length(phone) < 30);

alter table sets
add constraint yearlength
check (setyear < 9999);
