import React, { useContext, useEffect } from 'react'
import { useParams } from 'react-router-dom'
import { AppContext } from '../Contexts/AppContext';
import { Card, CardBody, CardHeader, CardTitle, CloseButton, Col, Container, ListGroup, Row } from 'react-bootstrap';
import UserRepo from './UserRepo';

const UserDetails = ({ login }) => {
    const context = useContext(AppContext)
    // const { login } = useParams();
    useEffect(() => {
        context.getUser(login);
        context.getRepos(login);
    }, [])
    return (
        <>
            <Card>
                <Row>
                    <Col xs={12}>
                        <CardHeader className='display-6 text-danger d-flex justify-content-between align-items-center'>
                            {context.user.name} ({context.user.login})
                            <CloseButton className='fs-6' onClick={() => context.setUser({})} />
                        </CardHeader>
                    </Col>
                </Row>
                <Row>
                    <Col xs={4}>
                        <CardBody>
                            <Row>
                                <Col>
                                    <Card.Img className='' src={context.user.avatar_url} />
                                </Col>
                            </Row>
                            <Row>
                                <Col>
                                    <CardBody className='d-flex justify-content-between align-items-center'>
                                        <CardTitle>Followers: {context.user.followers}</CardTitle><div className='mb-2'></div>
                                        <CardTitle>Following: {context.user.following}</CardTitle><div className='mb-2'></div>
                                    </CardBody>
                                </Col>
                            </Row>
                        </CardBody>
                    </Col>
                    <Col xs={8}>
                        <Row>
                            <Col xs={12}>
                                <Card.Body>
                                    <ListGroup className='flex-row flex-wrap justify-content-start'>
                                        {context.userRepos.map(userRepo => <UserRepo key={userRepo.id} userRepoName={userRepo.name} userRepoUrl={userRepo.html_url} />)}
                                    </ListGroup>
                                </Card.Body>
                            </Col>
                        </Row>
                    </Col>
                </Row>
            </Card>
        </>
    )
}

export default UserDetails