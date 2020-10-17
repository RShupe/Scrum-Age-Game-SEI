from django.contrib import admin
from .models import Player 

class PlayerAdmin(admin.ModelAdmin):  
  list_display = ('name', 'money', 'developers') 

# Register your models here.
admin.site.register(Player, PlayerAdmin) 