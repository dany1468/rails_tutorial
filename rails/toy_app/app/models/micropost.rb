class Micropost < ApplicationRecord
  belongs_to :user
  validates :content, length: {maximum: 140}, presence: true
  validates :email, presence: true
  validates :name, presence: true
end
