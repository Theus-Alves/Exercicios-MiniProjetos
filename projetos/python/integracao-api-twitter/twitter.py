import tweepy

# Autenticação na API do Twitter
consumer_key = 'SUA_CONSUMER_KEY'
consumer_secret = 'SUA_CONSUMER_SECRET'
access_token = 'SEU_ACCESS_TOKEN'
access_token_secret = 'SEU_ACCESS_TOKEN_SECRET'

auth = tweepy.OAuthHandler(consumer_key, consumer_secret)
auth.set_access_token(access_token, access_token_secret)

api = tweepy.API(auth)

# Enviar um tweet
api.update_status("Olá, Twitter! Este é um exemplo de tweet enviado via API do Twitter usando Python.")

# Obter tweets por palavra-chave
tweets = api.search(q="Python", count=10)
for tweet in tweets:
    print(tweet.text)

# Interagir com tweets
tweet_id = 'ID_DO_TWEET'
api.create_favorite(tweet_id)  # Favoritar um tweet
api.retweet(tweet_id)  # Retweetar um tweet
api.destroy_favorite(tweet_id)  # Remover o tweet dos favoritos
