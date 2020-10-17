from django.contrib import admin
from .models import Game 

class GameAdmin(admin.ModelAdmin):  
  list_display = ('name', 'playerNumber', 'completed',) 

# Register your models here.
admin.site.register(Game, GameAdmin) 