/* Write your T-SQL query statement below */
/*
select u.user_id as user_id , (select count(followers_id) from followers where user_id=u.user_id ) as  followers_count

from followers as u order by u.user_id

*/

select user_id, COUNT(follower_id ) as 'followers_count' from followers 
group by user_id 
order by user_id
--having count(follower_id)>0