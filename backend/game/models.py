from django.db import models

# Create your models here.
class Game(models.Model):
  name = models.CharField(max_length=120)
  playerNumber = models.IntegerField()
  completed = models.BooleanField(default=False)

  def _str_(self):
    return self.title