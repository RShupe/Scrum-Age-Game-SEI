from django.db import models

class Player(models.Model):
  name = models.CharField(max_length=120)
  money = models.IntegerField()
  developers = models.IntegerField()

  def _str_(self):
    return self.title