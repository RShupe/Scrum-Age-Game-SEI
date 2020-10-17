from django.contrib import admin
from django.urls import path, include                
from rest_framework import routers                    

router = routers.DefaultRouter()   

from game import views                   
router.register(r'games', views.GameView, 'game')        #adding the game to the api/game url

from player import views
router.register(r'players', views.PlayerView, 'player')  #adding the player to the api/player url

urlpatterns = [
    path('admin/', admin.site.urls),         
    path('api/', include(router.urls))                
]