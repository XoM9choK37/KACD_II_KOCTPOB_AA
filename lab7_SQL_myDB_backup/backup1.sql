--
-- PostgreSQL database dump
--

-- Dumped from database version 17.2
-- Dumped by pg_dump version 17.2

-- Started on 2025-04-03 13:26:36

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 4888 (class 1262 OID 24576)
-- Name: Students; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "Students" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';


ALTER DATABASE "Students" OWNER TO postgres;

\connect "Students"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 4889 (class 0 OID 0)
-- Name: Students; Type: DATABASE PROPERTIES; Schema: -; Owner: postgres
--

ALTER DATABASE "Students" SET effective_cache_size TO '65536';


\connect "Students"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 239 (class 1255 OID 24750)
-- Name: get_proc_curs(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.get_proc_curs() RETURNS text
    LANGUAGE plpgsql
    AS $$ 
declare 
ret text default ''; 
rec  record; 
curs refcursor; 
begin
call proc1(curs); 
	loop 
		fetch curs into rec; 
		exit when not found; 
		ret := ret || '{' || rec.surname || ' ' || rec.firstname ||
		' ' || rec.lastname || ' ' || 
		rec.birthplace || '}' ||E'\n'; 
	end loop; 
close curs; 
return ret; 
end; $$;


ALTER FUNCTION public.get_proc_curs() OWNER TO postgres;

--
-- TOC entry 240 (class 1255 OID 24748)
-- Name: get_students(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.get_students() RETURNS text
    LANGUAGE plpgsql
    AS $$ 
declare 
ret text default ''; 
rec  record; 
curs cursor for 
select * from students order by surname ASC, firstname ASC, lastname ASC;
begin 
	open curs; 
	loop 
		fetch curs into rec; 
		exit when not found; 
		ret := ret || '{' || rec.surname || ' ' || rec.firstname ||
		' ' || rec.lastname || ' ' || 
		rec.birthplace || '}' ||E'\n'; 
	end loop; 
	close curs; 
	return ret; 
end; $$;


ALTER FUNCTION public.get_students() OWNER TO postgres;

--
-- TOC entry 241 (class 1255 OID 24749)
-- Name: proc1(refcursor); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.proc1(INOUT curs refcursor)
    LANGUAGE plpgsql
    AS $$ 
DECLARE 
lcurs refcursor; 
BEGIN 
open lcurs for 
select * from students order by surname ASC, firstname ASC, lastname ASC;
curs = lcurs; 
END $$;


ALTER PROCEDURE public.proc1(INOUT curs refcursor) OWNER TO postgres;

--
-- TOC entry 234 (class 1255 OID 24743)
-- Name: procedurecsample3(); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.procedurecsample3()
    LANGUAGE sql
    AS $$
select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Correspondence'))$$;


ALTER PROCEDURE public.procedurecsample3() OWNER TO postgres;

--
-- TOC entry 232 (class 1255 OID 24741)
-- Name: procedureftsample3(); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.procedureftsample3()
    LANGUAGE sql
    AS $$
select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Full-time'))$$;


ALTER PROCEDURE public.procedureftsample3() OWNER TO postgres;

--
-- TOC entry 233 (class 1255 OID 24742)
-- Name: procedureptsample3(); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.procedureptsample3()
    LANGUAGE sql
    AS $$
select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Part-time'))$$;


ALTER PROCEDURE public.procedureptsample3() OWNER TO postgres;

--
-- TOC entry 235 (class 1255 OID 24744)
-- Name: procft3(); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.procft3()
    LANGUAGE sql
    AS $$select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Full-time'))$$;


ALTER PROCEDURE public.procft3() OWNER TO postgres;

--
-- TOC entry 236 (class 1255 OID 24746)
-- Name: query3function1(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.query3function1() RETURNS bigint
    LANGUAGE sql
    AS $$select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Full-time'))$$;


ALTER FUNCTION public.query3function1() OWNER TO postgres;

--
-- TOC entry 237 (class 1255 OID 24745)
-- Name: query3function2(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.query3function2() RETURNS bigint
    LANGUAGE sql
    AS $$select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Part-time'))$$;


ALTER FUNCTION public.query3function2() OWNER TO postgres;

--
-- TOC entry 238 (class 1255 OID 24747)
-- Name: query3function3(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.query3function3() RETURNS bigint
    LANGUAGE sql
    AS $$select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Correspondence'))$$;


ALTER FUNCTION public.query3function3() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 228 (class 1259 OID 24693)
-- Name: faculties; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.faculties (
    facultyid integer NOT NULL,
    facultyname text NOT NULL,
    descript text NOT NULL
);


ALTER TABLE public.faculties OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 24692)
-- Name: faculties_facultyid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.faculties ALTER COLUMN facultyid ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.faculties_facultyid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 222 (class 1259 OID 24609)
-- Name: groups; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.groups (
    groupid integer NOT NULL,
    setid integer NOT NULL,
    groupname text NOT NULL,
    teachformid integer NOT NULL
);


ALTER TABLE public.groups OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 24608)
-- Name: groups_groupid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.groups ALTER COLUMN groupid ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.groups_groupid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 220 (class 1259 OID 24598)
-- Name: sets; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.sets (
    setid integer NOT NULL,
    setname text NOT NULL,
    setyear integer NOT NULL,
    specialtyid integer NOT NULL,
    CONSTRAINT yearlength CHECK ((setyear < 9999))
);


ALTER TABLE public.sets OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 24597)
-- Name: sets_setid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.sets ALTER COLUMN setid ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.sets_setid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 218 (class 1259 OID 24579)
-- Name: specialities; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.specialities (
    specialtyid integer NOT NULL,
    specialtyname text NOT NULL,
    specialtycode text NOT NULL,
    descript text NOT NULL,
    facultyid integer NOT NULL
);


ALTER TABLE public.specialities OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 24578)
-- Name: specialities_specialtyid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.specialities ALTER COLUMN specialtyid ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.specialities_specialtyid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 226 (class 1259 OID 24667)
-- Name: students; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.students (
    studentid integer NOT NULL,
    groupid integer NOT NULL,
    surname text NOT NULL,
    firstname text NOT NULL,
    lastname text NOT NULL,
    birthday date NOT NULL,
    birthplace text NOT NULL,
    phone text NOT NULL,
    address text NOT NULL,
    CONSTRAINT phonelength CHECK ((length(phone) < 30))
);


ALTER TABLE public.students OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 24666)
-- Name: students_studentid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.students ALTER COLUMN studentid ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.students_studentid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 224 (class 1259 OID 24649)
-- Name: teachform; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.teachform (
    teachformid integer NOT NULL,
    descript text NOT NULL
);


ALTER TABLE public.teachform OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 24648)
-- Name: teachform_teachformid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.teachform ALTER COLUMN teachformid ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.teachform_teachformid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 231 (class 1259 OID 24737)
-- Name: viewcsample3; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.viewcsample3 AS
 SELECT groupname
   FROM public.groups
  WHERE ((setid IN ( SELECT sets.setid
           FROM public.sets
          WHERE (sets.setyear = 2015))) AND (teachformid IN ( SELECT teachform.teachformid
           FROM public.teachform
          WHERE (teachform.descript = 'Correspondence'::text))));


ALTER VIEW public.viewcsample3 OWNER TO postgres;

--
-- TOC entry 229 (class 1259 OID 24729)
-- Name: viewftsample3; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.viewftsample3 AS
 SELECT groupname
   FROM public.groups
  WHERE ((setid IN ( SELECT sets.setid
           FROM public.sets
          WHERE (sets.setyear = 2015))) AND (teachformid IN ( SELECT teachform.teachformid
           FROM public.teachform
          WHERE (teachform.descript = 'Full-time'::text))));


ALTER VIEW public.viewftsample3 OWNER TO postgres;

--
-- TOC entry 230 (class 1259 OID 24733)
-- Name: viewptsample3; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.viewptsample3 AS
 SELECT groupname
   FROM public.groups
  WHERE ((setid IN ( SELECT sets.setid
           FROM public.sets
          WHERE (sets.setyear = 2015))) AND (teachformid IN ( SELECT teachform.teachformid
           FROM public.teachform
          WHERE (teachform.descript = 'Part-time'::text))));


ALTER VIEW public.viewptsample3 OWNER TO postgres;

--
-- TOC entry 4882 (class 0 OID 24693)
-- Dependencies: 228
-- Data for Name: faculties; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.faculties OVERRIDING SYSTEM VALUE VALUES (1, 'FCTAM', 'Faculty of Computer Technology and Applied Mathematics');
INSERT INTO public.faculties OVERRIDING SYSTEM VALUE VALUES (2, 'FE', 'Faculty of Economics');


--
-- TOC entry 4876 (class 0 OID 24609)
-- Dependencies: 222
-- Data for Name: groups; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.groups OVERRIDING SYSTEM VALUE VALUES (24, 2, '26/2', 1);
INSERT INTO public.groups OVERRIDING SYSTEM VALUE VALUES (25, 3, '29/2', 2);


--
-- TOC entry 4874 (class 0 OID 24598)
-- Dependencies: 220
-- Data for Name: sets; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.sets OVERRIDING SYSTEM VALUE VALUES (2, '2015', 2015, 1);
INSERT INTO public.sets OVERRIDING SYSTEM VALUE VALUES (3, '2016', 2016, 2);


--
-- TOC entry 4872 (class 0 OID 24579)
-- Dependencies: 218
-- Data for Name: specialities; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.specialities OVERRIDING SYSTEM VALUE VALUES (1, 'FIIT', '02.03.02', 'Fundamental Informatics and Information Technologies', 1);
INSERT INTO public.specialities OVERRIDING SYSTEM VALUE VALUES (2, 'AMI', '01.03.02', 'Applied Mathematics and Informatics', 1);
INSERT INTO public.specialities OVERRIDING SYSTEM VALUE VALUES (3, 'SAM', '27.03.03', 'System Analysis and Management', 2);


--
-- TOC entry 4880 (class 0 OID 24667)
-- Dependencies: 226
-- Data for Name: students; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.students OVERRIDING SYSTEM VALUE VALUES (14, 24, 'Kostrov', 'Aleksandr', 'Alekseevich', '2005-08-12', 'Tbilisskaya', '+78005553535', 'Pushkin st., 2');
INSERT INTO public.students OVERRIDING SYSTEM VALUE VALUES (15, 24, 'Ivanov', 'Ivan', 'Ivanovich', '2002-07-11', 'Krasnodar', '+78005557777', 'Kolotushkin st., 3');
INSERT INTO public.students OVERRIDING SYSTEM VALUE VALUES (16, 25, 'Petrov', 'Petr', 'Petrovich', '2003-06-04', 'Moscow', '+78005554444', 'Tushkin st., 5');


--
-- TOC entry 4878 (class 0 OID 24649)
-- Dependencies: 224
-- Data for Name: teachform; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.teachform OVERRIDING SYSTEM VALUE VALUES (1, 'Full-time');
INSERT INTO public.teachform OVERRIDING SYSTEM VALUE VALUES (2, 'Part-time');
INSERT INTO public.teachform OVERRIDING SYSTEM VALUE VALUES (3, 'Correspondence');


--
-- TOC entry 4890 (class 0 OID 0)
-- Dependencies: 227
-- Name: faculties_facultyid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.faculties_facultyid_seq', 2, true);


--
-- TOC entry 4891 (class 0 OID 0)
-- Dependencies: 221
-- Name: groups_groupid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.groups_groupid_seq', 25, true);


--
-- TOC entry 4892 (class 0 OID 0)
-- Dependencies: 219
-- Name: sets_setid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.sets_setid_seq', 3, true);


--
-- TOC entry 4893 (class 0 OID 0)
-- Dependencies: 217
-- Name: specialities_specialtyid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.specialities_specialtyid_seq', 3, true);


--
-- TOC entry 4894 (class 0 OID 0)
-- Dependencies: 225
-- Name: students_studentid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.students_studentid_seq', 16, true);


--
-- TOC entry 4895 (class 0 OID 0)
-- Dependencies: 223
-- Name: teachform_teachformid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.teachform_teachformid_seq', 3, true);


--
-- TOC entry 4715 (class 2606 OID 24699)
-- Name: faculties faculties_facultyid_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.faculties
    ADD CONSTRAINT faculties_facultyid_key UNIQUE (facultyid);


--
-- TOC entry 4701 (class 2606 OID 24615)
-- Name: groups groups_groupid_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.groups
    ADD CONSTRAINT groups_groupid_key UNIQUE (groupid);


--
-- TOC entry 4717 (class 2606 OID 24701)
-- Name: faculties pkfaculties; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.faculties
    ADD CONSTRAINT pkfaculties PRIMARY KEY (facultyid);


--
-- TOC entry 4704 (class 2606 OID 24617)
-- Name: groups pkgroups; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.groups
    ADD CONSTRAINT pkgroups PRIMARY KEY (groupid);


--
-- TOC entry 4697 (class 2606 OID 24606)
-- Name: sets pksets; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sets
    ADD CONSTRAINT pksets PRIMARY KEY (setid);


--
-- TOC entry 4691 (class 2606 OID 24587)
-- Name: specialities pkspecialities; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.specialities
    ADD CONSTRAINT pkspecialities PRIMARY KEY (specialtyid);


--
-- TOC entry 4711 (class 2606 OID 24675)
-- Name: students pkstudents; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.students
    ADD CONSTRAINT pkstudents PRIMARY KEY (studentid);


--
-- TOC entry 4706 (class 2606 OID 24657)
-- Name: teachform pkteachform; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.teachform
    ADD CONSTRAINT pkteachform PRIMARY KEY (teachformid);


--
-- TOC entry 4699 (class 2606 OID 24604)
-- Name: sets sets_setid_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sets
    ADD CONSTRAINT sets_setid_key UNIQUE (setid);


--
-- TOC entry 4693 (class 2606 OID 24585)
-- Name: specialities specialities_specialtyid_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.specialities
    ADD CONSTRAINT specialities_specialtyid_key UNIQUE (specialtyid);


--
-- TOC entry 4713 (class 2606 OID 24673)
-- Name: students students_studentid_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.students
    ADD CONSTRAINT students_studentid_key UNIQUE (studentid);


--
-- TOC entry 4708 (class 2606 OID 24655)
-- Name: teachform teachform_teachformid_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.teachform
    ADD CONSTRAINT teachform_teachformid_key UNIQUE (teachformid);


--
-- TOC entry 4702 (class 1259 OID 24618)
-- Name: igroupsteachformid; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX igroupsteachformid ON public.groups USING btree (teachformid);


--
-- TOC entry 4695 (class 1259 OID 24607)
-- Name: isetssetyear; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX isetssetyear ON public.sets USING btree (setyear);


--
-- TOC entry 4694 (class 1259 OID 24588)
-- Name: specialtyindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX specialtyindex ON public.specialities USING btree (specialtyid);

ALTER TABLE public.specialities CLUSTER ON specialtyindex;


--
-- TOC entry 4709 (class 1259 OID 24658)
-- Name: teachfromindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX teachfromindex ON public.teachform USING btree (teachformid);


--
-- TOC entry 4720 (class 2606 OID 24624)
-- Name: groups fkgroupssets; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.groups
    ADD CONSTRAINT fkgroupssets FOREIGN KEY (setid) REFERENCES public.sets(setid) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 4721 (class 2606 OID 24703)
-- Name: groups fkgroupsteachform; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.groups
    ADD CONSTRAINT fkgroupsteachform FOREIGN KEY (teachformid) REFERENCES public.teachform(teachformid) ON UPDATE CASCADE;


--
-- TOC entry 4719 (class 2606 OID 24619)
-- Name: sets fksetsspecialities; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sets
    ADD CONSTRAINT fksetsspecialities FOREIGN KEY (specialtyid) REFERENCES public.specialities(specialtyid) ON UPDATE CASCADE;


--
-- TOC entry 4718 (class 2606 OID 24720)
-- Name: specialities fkspecialitiesfaculties; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.specialities
    ADD CONSTRAINT fkspecialitiesfaculties FOREIGN KEY (facultyid) REFERENCES public.faculties(facultyid) ON UPDATE CASCADE;


--
-- TOC entry 4722 (class 2606 OID 24676)
-- Name: students fkstudentsgroups; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.students
    ADD CONSTRAINT fkstudentsgroups FOREIGN KEY (groupid) REFERENCES public.groups(groupid) ON UPDATE CASCADE;


-- Completed on 2025-04-03 13:26:36

--
-- PostgreSQL database dump complete
--

