from django.shortcuts import render
from django.http import HttpResponse

def index(request):
    return HttpResponse('hello from here, I mean View.py')