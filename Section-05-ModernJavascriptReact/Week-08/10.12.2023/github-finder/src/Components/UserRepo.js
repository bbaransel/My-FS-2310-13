import React from 'react'
import { ListGroupItem } from 'react-bootstrap'
import { NavLink } from 'react-router-dom'

const UserRepo = ({ userRepoName, userRepoUrl }) => {
    return (
        <>
            <ListGroupItem className='w-auto' href={userRepoUrl} action={true} target='_blank'>
                {userRepoName}
            </ListGroupItem>
        </>
    )
}

export default UserRepo