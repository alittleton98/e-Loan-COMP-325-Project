-- disable all constraints
EXEC sp_MSforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all"

create table application(
  application_id        INT         not NULL    IDENTITY    PRIMARY KEY,
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
);

create table customer(
  customer_id        int    not null IDENTITY  PRIMARY KEY,
  application_id     int    not null,
  profile_id         int    not null,
  loan_details_id    int    not null,
);

create table profile(
  profile_id    int             not null IDENTITY  PRIMARY KEY,
  first_name    varchar(30)     not null,
  last_name     varchar(30)     not null,
  email         varchar(30)     not null,
  address_id    int             not null,
  phone_number  int         not null,
);

create table login(
  email               varchar(30)    not null PRIMARY KEY,
  password            varchar(30)    not null,
  customer_id         int            not null,
);

create table bank_details(
  bank_details_id    int        not null IDENTITY  PRIMARY KEY,
  loan_amount        Float(2)   not null,
  balance            Float(2)   not null,
  interest_rate      Float(2)   not null,
  tenure             int        not null,
  loan_date          DATE       not null,
);

create table loan_details (
  loan_details_id    int          not null IDENTITY  PRIMARY KEY,
  customer_id        int          not null,
  bank_name          varchar(25)  not null,
  routing_number     int          not null,
  account_number     int          not null,
);

create table address (
    address_id    int   not null IDENTITY  PRIMARY KEY,
    street        varchar not null,
    city        varchar not null,
    state        varchar not null,
    zip_code        varchar not null,
    country        varchar not null,
);

alter table application ADD foreign key (profile_id) references profile(profile_id);
alter table customer ADD foreign key (profile_id) references profile(profile_id);
alter table customer ADD foreign key (application_id) references application(application_id);
alter table customer ADD foreign key (loan_details_id) references loan_details(loan_details_id);
alter table profile ADD foreign key (address_id) references address(address_id);
alter table login ADD foreign key (customer_id) references customer(customer_id);
alter table loan_details ADD foreign key (customer_id) references customer(customer_id);
