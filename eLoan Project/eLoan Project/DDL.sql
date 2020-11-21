set FOREIGN_KEY_CHECKS=0;

DROP TABLE IF EXISTS aplication;
DROP TABLE IF EXISTS customer;
DROP TABLE IF EXISTS profile;
DROP TABLE IF EXISTS address;
DROP TABLE IF EXISTS login;
DROP TABLE IF EXISTS bank_details;
DROP TABLE IF EXISTS loan_details;

create table application(
  application_id        int         not null auto_increment,
  profile_id            int         not null,
  last4ssn              int         not null,
  loan_state            char(25)    not null,
  employee_name         varchar(50) not null,
  monthly_salary	      Float(2)    not null,
  rent_mortgage_expense Float(2)    not null,
  additional_expense    Float(2)    not null,
  amount_requested      Float(2)    not null,
  tenure_in_months      int         not null,
  application_date      Date        not null,


    primary key (application_id)
);

create table customer(
  customer_id        int    not null auto_increment,
  application_id     int    not null,
  profile_id         int    not null,
  loan_details_id    int    not null,

    primary key (customer_id)
);

create table profile(
  profile_id    varchar(255)    not null,
  first_name    varchar(30)     not null,
  last_name     varchar(30)     not null,
  email         varchar(30)     not null,
  address_id    int             not null,
  phone_number  int(10)         not null,

    primary key(profile_id)
);

create table login(
  email               varchar(30)    not null,
  password            varchar(30)    not null,
  customer_id         int            not null,

    primary key (email)
);

create table bank_details(
  bank_details_id    int        not null auto_increment,
  loan_amount        Float(2)   not null,
  balance            Float(2)   not null,
  interest_rate      Float(2)   not null,
  tenure             int        not null,
  loan_date          DATE       not null,

    primary key (bank_details_id)

);

create table loan_details (
  loan_details_id    int          not null auto_increment,
  customer_id        int          not null,
  bank_name          varchar(25)  not null,
  routing_number     int          not null,
  account_number     int          not null,

  primary key (loan_details_id)
);

alter table application ADD foreign key (profile_id) references profile(profile_id);
alter table customer ADD foreign key (profile_id) references profile(profile_id);
alter table customer ADD foreign key (application_id) references application(application_id);
alter table customer ADD foreign key (loan_details_id) references loan_details(loan_details_id);
alter table profile ADD foreign key (address_id) references address(address_id);
alter table login ADD foreign key (customer_id) references customer(customer_id);
alter table loan_details ADD foreign key (customer_id) references customer(customer_id);
