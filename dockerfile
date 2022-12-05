FROM php:7.2-apache

RUN apt-get -y update && apt-get -y install vim
COPY 000-default.conf /etc/apache2/sites-available/
