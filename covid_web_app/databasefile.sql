PGDMP     "                    z           covid-web-app-database    14.0    14.0     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    57711    covid-web-app-database    DATABASE     s   CREATE DATABASE "covid-web-app-database" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Greek_Greece.1253';
 (   DROP DATABASE "covid-web-app-database";
                postgres    false            �            1259    57712    patient    TABLE     �  CREATE TABLE public.patient (
    first_name character varying NOT NULL,
    last_name character varying NOT NULL,
    email character varying NOT NULL,
    phone character varying NOT NULL,
    gender character varying NOT NULL,
    age smallint NOT NULL,
    diseases character varying,
    address character varying NOT NULL,
    date timestamp without time zone NOT NULL,
    id bigint NOT NULL
);
    DROP TABLE public.patient;
       public         heap    postgres    false            �          0    57712    patient 
   TABLE DATA           p   COPY public.patient (first_name, last_name, email, phone, gender, age, diseases, address, date, id) FROM stdin;
    public          postgres    false    209   �       \           2606    57718    patient patient_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.patient
    ADD CONSTRAINT patient_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.patient DROP CONSTRAINT patient_pkey;
       public            postgres    false    209            �   �   x�=�An�0E��Sp��ccVq��XIC��]7V
�����E7_o���?��+�O�x�]�wråk����p�qI�~�o��cN�T~�`�&�6��i�Hx�]>������ic�T!�D'�)��ljD�Yk1�����'}�t+?�ig-�f��sN�����J�ʪ��T*�/�+�Q
!~�f6P     